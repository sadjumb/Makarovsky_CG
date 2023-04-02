using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace WindowsFormsApp1
{
  abstract class Filters
  {
    virtual public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      for (int i = 0; i < sourceImage.Width; ++i)
      {
        worker.ReportProgress((int)((float)i / resultImage.Width * 100));
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; ++j)
        {
          resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
        }
      }
      return resultImage;
    }

    protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int x, int y);

    public int Clamp(int value, int min, int max)
    {
      if (value < min)
      {
        return min;
      }
      else if (value > max)
      {
        return max;
      }
      return value;
    }
  }

  class InvertFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color color = Color.FromArgb(255 - sourceImage.GetPixel(x, y).R, 255 - sourceImage.GetPixel(x, y).G, 255 - sourceImage.GetPixel(x, y).B);
      return color;
    }
  }

  class GrayScaleFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int intensity = Convert.ToInt32(0.36 * sourceImage.GetPixel(x, y).R + 0.53 * sourceImage.GetPixel(x, y).G + 0.11 * sourceImage.GetPixel(x, y).B);
      Color color = Color.FromArgb(intensity, intensity, intensity);
      return color;
    }
  }
  class SepiyFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int intensity = Convert.ToInt32(0.36 * sourceImage.GetPixel(x, y).R + 0.53 * sourceImage.GetPixel(x, y).G + 0.11 * sourceImage.GetPixel(x, y).B);
      float k = 25;
      return Color.FromArgb(Clamp((int)(intensity + 2 * k), 0, 255), Clamp((int)(intensity + 0.5 * k), 0, 255), Clamp((int)(intensity - k), 0, 255));

    }
  }

  class BrightnessFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int k = 30;
      return Color.FromArgb(Clamp((int)(sourceImage.GetPixel(x, y).R + k), 0, 255), Clamp((int)(sourceImage.GetPixel(x, y).G + k), 0, 255), Clamp((int)(sourceImage.GetPixel(x, y).B + k), 0, 255));
    }
  }

  class WavesFilter : Filters
  {
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int lastX = x;
      x = x + (int)(20 * Math.Sin(2 * Math.PI * y / 128.0f));
      if (x >= sourceImage.Width || x < 0)
        return Color.FromArgb(0, 0, 0);
      return Color.FromArgb(Clamp((int)(sourceImage.GetPixel(x, y).R), 0, 255), Clamp((int)(sourceImage.GetPixel(x, y).G), 0, 255), Clamp((int)(sourceImage.GetPixel(x, y).B), 0, 255)); ;
    }
  }

  class GlassesFilter : Filters
  {
    Random random = new Random();
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      x = x + (int)((random.NextDouble() - 0.5) * 10);
      y = y + (int)((random.NextDouble() - 0.5) * 10);
      if (x >= sourceImage.Width || x < 0 || y >= sourceImage.Height || y < 0)
        return Color.FromArgb(0, 0, 0);
      return Color.FromArgb(Clamp((int)(sourceImage.GetPixel(x, y).R), 0, 255), Clamp((int)(sourceImage.GetPixel(x, y).G), 0, 255), Clamp((int)(sourceImage.GetPixel(x, y).B), 0, 255));
    }
  }



  class MatrixFilter : Filters
  {
    protected float[,] kernel = null;

    protected MatrixFilter() { }
    public MatrixFilter(float[,] kernel)
    {
      this.kernel = kernel;
    }

    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int radiusX = kernel.GetLength(0) / 2;
      int radiusY = kernel.GetLength(1) / 2;
      float resultR = 0;
      float resultG = 0;
      float resultB = 0;

      for (int l = -radiusY; l <= radiusY; ++l)
      {
        for (int k = -radiusX; k <= radiusX; ++k)
        {
          int idx = Clamp(x + k, 0, sourceImage.Width - 1);
          int idy = Clamp(y + l, 0, sourceImage.Height - 1);
          Color neighborColor = sourceImage.GetPixel(idx, idy);
          resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
          resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
          resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
        }
      }
      return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
    }
  }

  class BlureFilter : MatrixFilter
  {
    public BlureFilter()
    {
      int sizeX = 3;
      int sizeY = 3;
      kernel = new float[sizeX, sizeY];
      for (int i = 0; i < sizeX; ++i)
      {
        for (int j = 0; j < sizeY; ++j)
        {
          kernel[i, j] = 1.0f / (float)(sizeY * sizeX);
        }
      }
    }
  }

  class GaussianFilter : MatrixFilter
  {
    public GaussianFilter()
    {
      createGaussianKernel(3, 1f);
    }

    public void createGaussianKernel(int radius, float sigma)
    {
      int size = radius * 2 + 1;
      kernel = new float[size, size];
      float norm = 0;
      for (int i = -radius; i <= radius; ++i)
      {
        for (int j = -radius; j <= radius; ++j)
        {
          kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma))) / (float)(Math.Sqrt(2 * Math.PI) * sigma * sigma);
          norm += kernel[i + radius, j + radius];
        }
      }
      for (int i = 0; i < size; ++i)
      {
        for (int j = 0; j < size; ++j)
        {
          kernel[i, j] /= norm;
        }
      }
    }

  }

  class SharpnessFilter : MatrixFilter
  {
    public SharpnessFilter()
    {
      kernel = new float[3, 3] { {0 ,  -1,   0},
                                 {-1,  5 ,   -1},
                                 {0 ,  -1,   0} };
    }
  }

  class SobelFilter : MatrixFilter
  {
    protected float[,] kernelX = null;
    protected float[,] kernelY = null;

    public SobelFilter()
    {
      kernelX = new float[3, 3] {{-1,  0,   1},
                                 {-2,  0,   2},
                                 {-1,  0,   1}};
      kernelY = new float[3, 3] {{-1,  -2,   -1},
                                 { 0,   0,    0},
                                 { 1,   2,    1}};
    }
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int radiusX = kernelX.GetLength(0) / 2;
      int radiusY = kernelX.GetLength(1) / 2;
      float xR = 0;
      float xG = 0;
      float xB = 0;
      float yR = 0;
      float yG = 0;
      float yB = 0;

      for (int l = -radiusY; l <= radiusY; ++l)
      {
        for (int k = -radiusX; k <= radiusX; ++k)
        {
          int idx = Clamp(x + k, 0, sourceImage.Width - 1);
          int idy = Clamp(y + l, 0, sourceImage.Height - 1);
          Color neighborColor = sourceImage.GetPixel(idx, idy);
          xR += neighborColor.R * kernelX[k + radiusX, l + radiusY];
          xG += neighborColor.G * kernelX[k + radiusX, l + radiusY];
          xB += neighborColor.B * kernelX[k + radiusX, l + radiusY];

          yR += neighborColor.R * kernelY[k + radiusX, l + radiusY];
          yG += neighborColor.G * kernelY[k + radiusX, l + radiusY];
          yB += neighborColor.B * kernelY[k + radiusX, l + radiusY];
        }
      }
      return Color.FromArgb(Clamp((int)Math.Sqrt((xR * xR) + (yR * yR)), 0, 255), Clamp((int)Math.Sqrt((xG * xG) + (yG * yG)), 0, 255), Clamp((int)Math.Sqrt((xB * xB) + (yB * yB)), 0, 255));
    }


  }

  class OperatorSharraFilter : SobelFilter
  {
    public OperatorSharraFilter()
    {
      kernelX = new float[3, 3] {{ 3,  0,    -3},
                                 {10,  0,   -10},
                                 { 3,  0,    -3}};
      kernelY = new float[3, 3] { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };
    }
  }


  class MathMorph : Filters
  {
    public MathMorph(){}

    public MathMorph(int[,] mask, int MH, int MW)
    {
      this.mask = mask;
      this.MH = MH;
      this.MW = MW;
    }

    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      throw new NotImplementedException();
    }

    protected int[,] mask = null;
    protected int MH;
    protected int MW;
  }

  class DilationFilter : MathMorph
  {
    public DilationFilter() 
    {
      MH = 3;
      MW = 3;
      mask = new int[3, 3] { { 0, 1, 0 },
                             { 1, 1, 1 },
                             { 0, 1, 0 } };
    }
    public DilationFilter(int[,] mask, int MH, int MW) //: base(mask, MH, MW)
    {
      this.mask = mask;
      this.MH = MH;
      this.MW = MW;
    }
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color max = Color.FromArgb(0, 0, 0);
      for (int j = -MH / 2; j <= MH / 2; ++j)
      {
        for (int i = -MW / 2; i <= MW / 2; ++i)
        {
          Color sourceColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
          if (mask[i + MW / 2, j + MH / 2] == 1 && sourceColor.R > max.R)
          {
            max = sourceColor;
          }
        }
      }
      return max;
    }
  }
  class ErosionFilter : MathMorph
  {
    public ErosionFilter()
    {
      MH = 3;
      MW = 3;
      mask = new int[3, 3] { { 0, 1, 0 },
                             { 1, 1, 1 },
                             { 0, 1, 0 } };
    }
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color min = Color.FromArgb(255, 255, 255);
      for (int j = -MH / 2; j <= MH / 2; ++j)
      {
        for (int i = -MW / 2; i <= MW / 2; ++i)
        {
          Color sourceColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
          if (mask[i + MW / 2, j + MH / 2] == 1 && sourceColor.R < min.R)
          {
            min = sourceColor;
          }
        }
      }
      return min;
    }
  }

  class GradientFilter : MathMorph
  {
    public GradientFilter() 
    {
      MH = 3;
      MW = 3;
      mask = new int[3, 3] { { 0, 1, 0 },
                             { 1, 1, 1 },
                             { 0, 1, 0 } };
    }
    override public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      for (int i = 0; i < sourceImage.Width; ++i)
      {
        worker.ReportProgress((int)((float)i / resultImage.Width * 100));
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; ++j)
        {
          resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
        }
      }
      return resultImage;
    }
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color min = Color.FromArgb(255, 255, 255);
      Color max = Color.FromArgb(0, 0, 0);
      for (int j = -MH / 2; j <= MH / 2; ++j)
      {
        for (int i = -MW / 2; i <= MW / 2; ++i)
        {
          Color sourceColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
          if (mask[i + MW / 2, j + MH / 2] == 1 && sourceColor.R < min.R)
          {
            min = sourceColor;
          }
          if (mask[i + MW / 2, j + MH / 2] == 1 && sourceColor.R > max.R)
          {
            max = sourceColor;
          }
        }
      }
      return Color.FromArgb(Clamp(max.R - min.R, 0, 255), Clamp(max.G - min.G, 0, 255), Clamp(max.B - min.B, 0, 255));
    }
  }


  class MedianFilter : MathMorph
  {
    public MedianFilter(){}
    protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int size = 3;
      int radius = 1;
      int[] cR = new int[size * size];
      int[] cG = new int[size * size];
      int[] cB = new int[size * size];
      int k = 0;

      for (int i = -radius; i <= radius; i++)
        for (int j = -radius; j <= radius; j++)
        {
          Color sourceColor = sourceImage.GetPixel(Clamp(x + i, 0, sourceImage.Width - 1), Clamp(y + j, 0, sourceImage.Height - 1));
          cR[k] = sourceColor.R;
          cG[k] = sourceColor.G;
          cB[k] = sourceColor.B;
          k++;
        }

      Array.Sort(cR);
      Array.Sort(cG);
      Array.Sort(cB);

      int n_ = (int)(size * size / 2);

      int cR_ = cR[n_];
      int cG_ = cG[n_];
      int cB_ = cB[n_];

      Color resultColor = Color.FromArgb(cR_, cG_, cB_);
      return resultColor;
    }
  }

}