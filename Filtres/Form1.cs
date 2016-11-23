using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filtres
{
    public partial class Form1 : Form
    {
        Bitmap image, image1;
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
           // Form1.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }

        /*private void Form1_Resize(object sender, EventArgs e)
        {
            
            pictureBox1.Height = Form1.ActiveForm.Size.Height - 50;
            pictureBox1.Width = Form1.ActiveForm.Width - 50;
            button1.Location = new Point(pictureBox1.Width - 59, pictureBox1.Height - 24);
            progressBar1.Location = new Point(pictureBox1.Width - 520, pictureBox1.Height - 24);

        }*/

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " Image Files | *.png; *.jpg;*.jpeg; *.bmp| All Files (*.*)| *.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                image1 = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
                pointingToolStripMenuItem.Enabled = true;
                matrixToolStripMenuItem.Enabled = true;
                artFiltresToolStripMenuItem.Enabled = true;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dial = new SaveFileDialog();
            dial.Filter = " JPEG |   *.jpg; *.jpeg;| PNG | *.png";
            if (dial.ShowDialog() == DialogResult.OK)
            {
                image.Save(dial.FileName);
            }
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FewFiltres filter = new InvertFilter();

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {            
            image = ((FewFiltres)e.Argument).processImage(image, backgroundWorker1);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pictureBox1.Image = image;
            pictureBox1.Refresh();
            Form1.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void grayScaleFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///////Form1.ActiveForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            FewFiltres filter = new Sepia();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void размытиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gaussianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new Filtrer_of_Sobel();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void braitnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new BraitnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void harshnessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new HarshnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void stampingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new StampingFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void harshness2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new Harshness2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void motionBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new MotionBlur();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void waves1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new WavesFilter1();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void поворотToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new turn();
            backgroundWorker1.RunWorkerAsync(filter);

        }

        private void wavesVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new WavesFilter2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void glassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new Glass();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void сдвигToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new shift();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image = image1;
            pictureBox1.Image = image1;
        }

        private void shiftRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new shift2();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void greyWorldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new GreyWorld(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pointingToolStripMenuItem.Enabled = false;
            matrixToolStripMenuItem.Enabled = false;
            artFiltresToolStripMenuItem.Enabled = false;
        }

        private void closeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dilationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new Dilation();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void erosionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FewFiltres filter = new Erosion();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }


    }
}
