using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Diagnostics.Tracing;
using System.Drawing.Imaging;

namespace SegundoDIP
{
    public partial class Form1 : Form
    {
        Bitmap loaded, processed, foreground, subtracted, subtractedOutput;
        BitmapFilter bitmapFilter;
        private FilterInfoCollection videoDevices; // Collection of camera devices
        private VideoCaptureDevice videoSource; // Selected camera device
        public Form1()
        {
            InitializeComponent();
            bitmapFilter = new BitmapFilter();
            filterSelect.SelectedIndex = 0;
            filterSubtractedSelect.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        // Filters

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void inputFilterBox_Click(object sender, EventArgs e)
        {

        }

        private void chooseFilterButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(filterSelect.SelectedItem);

            //Copy
            //Greyscale
            //Inversion
            //Sepia
            //Histogram

            Bitmap temp = null;


            temp = (Bitmap)loaded.Clone();


            switch (filterSelect.SelectedItem)
            {
                case "Copy":
                    DIPHelper.DuplicateBitmap(ref temp, ref processed);
                    break;
                case "Greyscale":
                    DIPHelper.ConvertToGrayscale(ref temp, ref processed);
                    break;
                case "Inversion":
                    DIPHelper.ApplyInversion(ref temp, ref processed);
                    break;
                case "Sepia":
                    DIPHelper.ApplySepiaTone(ref temp, ref processed);
                    break;
                case "Histogram":
                    DIPHelper.GenerateHistogram(ref temp, ref processed);
                    break;
                case "Smoothing":
                    BitmapFilter.Smooth(temp,1);
                    processed = temp;
                    break;
                case "Gaussian Blur":
                    BitmapFilter.GaussianBlur(temp, 4);
                    processed = temp;
                    break;
                case "Sharpen":
                    BitmapFilter.Sharpen(temp, 11);
                    processed = temp;
                    break;
                case "Mean Removal":
                    BitmapFilter.MeanRemoval(temp,9);
                    processed = temp;
                    break;
                case "Emboss Laplacian":
                    BitmapFilter.EmbossLaplacian(temp);
                    processed = temp;
                    break;
                case "Edge Enhance":
                    BitmapFilter.EdgeEnhance(temp, (byte)1);
                    processed = temp;
                    break;
                case "Edge Detect":
                    BitmapFilter.EdgeDetectDifference(temp, (byte)1);
                    processed = temp;
                    break;
            }

            outputFilterBox.Image = processed;
            saveOutputButton.Enabled = true;
        }

        private void saveOutputButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                outputFilterBox.Image.Save(sfd.FileName, format);
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            loaded = new Bitmap(openFileDialog1.FileName);
            inputFilterBox.Image = loaded;
            backgroundBox.Image = loaded;

            filterSelect.Enabled = true;
            chooseFilterButton.Enabled = true; 
            openForegroundToolStripMenuItem.Enabled = true;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            foreground = new Bitmap(openFileDialog2.FileName);
            foregroundBox.Image = foreground;

            subtractButton.Enabled = true;
           
           
        }

        private void backgroundBox_Click(object sender, EventArgs e)
        {

        }

        private void foregroundBox_Click(object sender, EventArgs e)
        {

        }

        


        private void subtractButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = null;
            if (videoSource != null && videoSource.IsRunning)
            {
                temp = (Bitmap)loaded.Clone();

                
            }
            else
            {
                temp = loaded;
            }

            DIPHelper.RemoveGreen(ref temp, ref foreground, ref subtracted);


            subtractedBox.Image = subtracted;


            saveSubtractedButton.Enabled = true;
            filterSubtractedSelect.Enabled = true;
            chooseFilterSubtractedButton.Enabled = true;
        }

        private void chooseFilterSubtractedButton_Click(object sender, EventArgs e)
        {
            Bitmap temp = null;
            //if (videoSource != null && videoSource.IsRunning)
            //{
            //    temp = (Bitmap)loaded.Clone();


            //}
            //else
            //{
            //    temp = loaded;
            //}

            temp = (Bitmap)subtracted.Clone(); ;
          

            switch (filterSubtractedSelect.SelectedItem)
            {
                case "Copy":
                    DIPHelper.DuplicateBitmap(ref subtracted, ref subtractedOutput);
                    break;
                case "Greyscale":
                    DIPHelper.ConvertToGrayscale(ref subtracted, ref subtractedOutput);
                    break;
                case "Inversion":
                    DIPHelper.ApplyInversion(ref subtracted, ref subtractedOutput);
                    break;
                case "Sepia":
                    DIPHelper.ApplySepiaTone(ref subtracted, ref subtractedOutput);
                    break;
                case "Histogram":
                    DIPHelper.GenerateHistogram(ref subtracted, ref subtractedOutput);
                    break;
                case "Smoothing":
                    BitmapFilter.Smooth(temp, 1);
                    subtractedOutput = temp;
                    break;
                case "Gaussian Blur":
                    BitmapFilter.GaussianBlur(temp, 4);
                    subtractedOutput = temp;
                    break;
                case "Sharpen":
                    BitmapFilter.Sharpen(temp, 11);
                    subtractedOutput = temp;
                    break;
                case "Mean Removal":
                    BitmapFilter.MeanRemoval(temp, 9);
                    subtractedOutput = temp;
                    break;
                case "Emboss Laplacian":
                    BitmapFilter.EmbossLaplacian(temp);
                    subtractedOutput = temp;
                    break;
                case "Edge Enhance":
                    BitmapFilter.EdgeEnhance(temp, (byte)1);
                    subtractedOutput = temp;
                    break;
                case "Edge Detect":
                    BitmapFilter.EdgeDetectDifference(temp, (byte)1);
                    subtractedOutput = temp;
                    break;

            }

            subtractedBox.Image = subtractedOutput;


        }

        private void saveSubtractedButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            ImageFormat format = ImageFormat.Png;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = System.IO.Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                subtractedBox.Image.Save(sfd.FileName, format);
            }
        }

        private void filterSubtractedSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outputFilterBox_Click(object sender, EventArgs e)
        {

        }

        private void openBackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }

            if(loaded != null)
                loaded.Dispose();

            openFileDialog1.ShowDialog();

        }

        private void openCameraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video sources found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine(videoDevices.Count);

            videoSource = new VideoCaptureDevice(videoDevices[videoDevices.Count - 1].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(VideoSource_NewFrame);
            videoSource.Start();

            filterSelect.Enabled = true;
            chooseFilterButton.Enabled = true;
            openForegroundToolStripMenuItem.Enabled = true;
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            loaded = bitmap;


            // Display the frame in the PictureBox
            inputFilterBox.Image = bitmap;
            backgroundBox.Image = bitmap;

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }

        private void openForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }
    }
}
