namespace WindowsFormsApp1
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.increaseBrightnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.glassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.matrixsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.blurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sharpnessToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filtersSobelyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sharraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mathMorphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dilationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.erosionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gradientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.medianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.createKernelForMathMorphologyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.button2 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.menuStrip1.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.fileToolStripMenuItem,
            this.createKernelForMathMorphologyToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1638, 31);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 27);
      this.toolStripMenuItem1.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
      this.openToolStripMenuItem.Text = "Open";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(124, 28);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dotsToolStripMenuItem,
            this.matrixsToolStripMenuItem,
            this.mathMorphologyToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
      this.fileToolStripMenuItem.Text = "Filters";
      // 
      // dotsToolStripMenuItem
      // 
      this.dotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inverseToolStripMenuItem,
            this.wBToolStripMenuItem,
            this.sepiaToolStripMenuItem,
            this.increaseBrightnessToolStripMenuItem,
            this.wavesToolStripMenuItem,
            this.glassesToolStripMenuItem});
      this.dotsToolStripMenuItem.Name = "dotsToolStripMenuItem";
      this.dotsToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
      this.dotsToolStripMenuItem.Text = "Dots";
      // 
      // inverseToolStripMenuItem
      // 
      this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
      this.inverseToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
      this.inverseToolStripMenuItem.Text = "Inversion";
      this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
      // 
      // wBToolStripMenuItem
      // 
      this.wBToolStripMenuItem.Name = "wBToolStripMenuItem";
      this.wBToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
      this.wBToolStripMenuItem.Text = "W/B";
      this.wBToolStripMenuItem.Click += new System.EventHandler(this.wBToolStripMenuItem_Click);
      // 
      // sepiaToolStripMenuItem
      // 
      this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
      this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
      this.sepiaToolStripMenuItem.Text = "Sepia";
      this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
      // 
      // increaseBrightnessToolStripMenuItem
      // 
      this.increaseBrightnessToolStripMenuItem.Name = "increaseBrightnessToolStripMenuItem";
      this.increaseBrightnessToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
      this.increaseBrightnessToolStripMenuItem.Text = "increase brightness";
      this.increaseBrightnessToolStripMenuItem.Click += new System.EventHandler(this.increaseBrightnessToolStripMenuItem_Click);
      // 
      // wavesToolStripMenuItem
      // 
      this.wavesToolStripMenuItem.Name = "wavesToolStripMenuItem";
      this.wavesToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
      this.wavesToolStripMenuItem.Text = "Waves";
      this.wavesToolStripMenuItem.Click += new System.EventHandler(this.wavesToolStripMenuItem_Click);
      // 
      // glassesToolStripMenuItem
      // 
      this.glassesToolStripMenuItem.Name = "glassesToolStripMenuItem";
      this.glassesToolStripMenuItem.Size = new System.Drawing.Size(236, 28);
      this.glassesToolStripMenuItem.Text = "Glasses";
      this.glassesToolStripMenuItem.Click += new System.EventHandler(this.glassesToolStripMenuItem_Click);
      // 
      // matrixsToolStripMenuItem
      // 
      this.matrixsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurToolStripMenuItem,
            this.gaussianToolStripMenuItem,
            this.sharpnessToolStripMenuItem,
            this.filtersSobelyaToolStripMenuItem,
            this.sharraToolStripMenuItem});
      this.matrixsToolStripMenuItem.Name = "matrixsToolStripMenuItem";
      this.matrixsToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
      this.matrixsToolStripMenuItem.Text = "Matrices";
      // 
      // blurToolStripMenuItem
      // 
      this.blurToolStripMenuItem.Name = "blurToolStripMenuItem";
      this.blurToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
      this.blurToolStripMenuItem.Text = "Blur";
      this.blurToolStripMenuItem.Click += new System.EventHandler(this.blurToolStripMenuItem_Click);
      // 
      // gaussianToolStripMenuItem
      // 
      this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
      this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
      this.gaussianToolStripMenuItem.Text = "Gaussian";
      this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.gaussianToolStripMenuItem_Click);
      // 
      // sharpnessToolStripMenuItem
      // 
      this.sharpnessToolStripMenuItem.Name = "sharpnessToolStripMenuItem";
      this.sharpnessToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
      this.sharpnessToolStripMenuItem.Text = "Sharpness";
      this.sharpnessToolStripMenuItem.Click += new System.EventHandler(this.sharpnessToolStripMenuItem_Click);
      // 
      // filtersSobelyaToolStripMenuItem
      // 
      this.filtersSobelyaToolStripMenuItem.Name = "filtersSobelyaToolStripMenuItem";
      this.filtersSobelyaToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
      this.filtersSobelyaToolStripMenuItem.Text = "Filter\'s Sobelya";
      this.filtersSobelyaToolStripMenuItem.Click += new System.EventHandler(this.filtersSobelyaToolStripMenuItem_Click);
      // 
      // sharraToolStripMenuItem
      // 
      this.sharraToolStripMenuItem.Name = "sharraToolStripMenuItem";
      this.sharraToolStripMenuItem.Size = new System.Drawing.Size(208, 28);
      this.sharraToolStripMenuItem.Text = "Sharra";
      this.sharraToolStripMenuItem.Click += new System.EventHandler(this.sharraToolStripMenuItem_Click);
      // 
      // mathMorphologyToolStripMenuItem
      // 
      this.mathMorphologyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dilationToolStripMenuItem,
            this.erosionToolStripMenuItem,
            this.gradientToolStripMenuItem,
            this.medianToolStripMenuItem});
      this.mathMorphologyToolStripMenuItem.Name = "mathMorphologyToolStripMenuItem";
      this.mathMorphologyToolStripMenuItem.Size = new System.Drawing.Size(229, 28);
      this.mathMorphologyToolStripMenuItem.Text = "Math morphology";
      // 
      // dilationToolStripMenuItem
      // 
      this.dilationToolStripMenuItem.Name = "dilationToolStripMenuItem";
      this.dilationToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
      this.dilationToolStripMenuItem.Text = "Dilation";
      this.dilationToolStripMenuItem.Click += new System.EventHandler(this.dilationToolStripMenuItem_Click);
      // 
      // erosionToolStripMenuItem
      // 
      this.erosionToolStripMenuItem.Name = "erosionToolStripMenuItem";
      this.erosionToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
      this.erosionToolStripMenuItem.Text = "Erosion";
      this.erosionToolStripMenuItem.Click += new System.EventHandler(this.erosionToolStripMenuItem_Click);
      // 
      // gradientToolStripMenuItem
      // 
      this.gradientToolStripMenuItem.Name = "gradientToolStripMenuItem";
      this.gradientToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
      this.gradientToolStripMenuItem.Text = "Gradient";
      this.gradientToolStripMenuItem.Click += new System.EventHandler(this.gradientToolStripMenuItem_Click);
      // 
      // medianToolStripMenuItem
      // 
      this.medianToolStripMenuItem.Name = "medianToolStripMenuItem";
      this.medianToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
      this.medianToolStripMenuItem.Text = "Median";
      this.medianToolStripMenuItem.Click += new System.EventHandler(this.medianToolStripMenuItem_Click);
      // 
      // createKernelForMathMorphologyToolStripMenuItem
      // 
      this.createKernelForMathMorphologyToolStripMenuItem.Name = "createKernelForMathMorphologyToolStripMenuItem";
      this.createKernelForMathMorphologyToolStripMenuItem.Size = new System.Drawing.Size(318, 27);
      this.createKernelForMathMorphologyToolStripMenuItem.Text = "Create kernel for Math Morphology";
      // 
      // backgroundWorker1
      // 
      this.backgroundWorker1.WorkerReportsProgress = true;
      this.backgroundWorker1.WorkerSupportsCancellation = true;
      this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
      this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
      this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Controls.Add(this.button1);
      this.groupBox1.Controls.Add(this.progressBar1);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.groupBox1.Location = new System.Drawing.Point(0, 862);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(1638, 58);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(1534, 19);
      this.button2.Name = "button2";
      this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.button2.Size = new System.Drawing.Size(92, 33);
      this.button2.TabIndex = 2;
      this.button2.Text = "back";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(407, 19);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(110, 33);
      this.button1.TabIndex = 1;
      this.button1.Text = "Cancel";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // progressBar1
      // 
      this.progressBar1.Location = new System.Drawing.Point(12, 19);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(363, 33);
      this.progressBar1.TabIndex = 0;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pictureBox1.Location = new System.Drawing.Point(0, 31);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1638, 889);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 1;
      this.pictureBox1.TabStop = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1638, 920);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.MaximumSize = new System.Drawing.Size(1654, 959);
      this.MinimumSize = new System.Drawing.Size(772, 604);
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dotsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem matrixsToolStripMenuItem;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ToolStripMenuItem blurToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wBToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem increaseBrightnessToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sharpnessToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem filtersSobelyaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wavesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem glassesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sharraToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mathMorphologyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dilationToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem erosionToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem gradientToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem medianToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem createKernelForMathMorphologyToolStripMenuItem;
    private System.Windows.Forms.Button button2;
  }
}

