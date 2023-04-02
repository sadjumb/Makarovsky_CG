using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public partial class Form1 : Form
  {
    private List<Bitmap> imageList = new List<Bitmap>();
    Bitmap image;
    public Form1()
    {
      InitializeComponent();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Filter = "Image file | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";

      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        image = new Bitmap(openFileDialog.FileName);
        imageList.Add(image);
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }
    }

    private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters invertFilter = new InvertFilter();
      backgroundWorker1.RunWorkerAsync(invertFilter);
    }

    private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
    {
      Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
      if (backgroundWorker1.CancellationPending != true)
      {
        image = newImage;
        imageList.Add(image);
      }
    }

    private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      progressBar1.Value = e.ProgressPercentage;
    }

    private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
      if (!e.Cancelled)
      {
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      }
      progressBar1.Value = 0;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      backgroundWorker1.CancelAsync();
    }

    private void blurToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new BlureFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GaussianFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void wBToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GrayScaleFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new SepiyFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void increaseBrightnessToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new BrightnessFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void sharpnessToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new SharpnessFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void filtersSobelyaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new SobelFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Filter = "Images|*.png;*.bmp;*.jpg";
      saveFileDialog.Title = "Save an Image File";
      ImageFormat format = ImageFormat.Png;

      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        string ext = System.IO.Path.GetExtension(saveFileDialog.FileName);
        switch (ext)
        {
          case ".jpg":
            format = ImageFormat.Jpeg;
            break;
          case ".bmp":
            format = ImageFormat.Bmp;
            break;
        }
        pictureBox1.Image.Save(saveFileDialog.FileName, format);
      }

    }

    private void wavesToolStripMenuItem_Click(object sender, EventArgs e)
    {

      Filters filter = new WavesFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void glassesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GlassesFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void sharraToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new OperatorSharraFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new DilationFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new ErosionFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void gradientToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new GradientFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void medianToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Filters filter = new MedianFilter();
      backgroundWorker1.RunWorkerAsync(filter);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (imageList.Count > 1)
      {
        image = imageList[imageList.Count - 2];
        imageList.RemoveAt(imageList.Count - 1);
        pictureBox1.Image = image;
        pictureBox1.Refresh();
      } 
    }
  }
}
