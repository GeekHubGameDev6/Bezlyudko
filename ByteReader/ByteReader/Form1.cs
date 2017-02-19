using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteReader
{
    public partial class Form1 : Form
    {
        private byte[] byteArray = null; 
        private static readonly ImageConverter _imageConverter = new ImageConverter();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBoxFilePath.Text = openFileDialog1.FileName;
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            string textPath = textBoxFilePath.Text;
            byteArray = File.ReadAllBytes(textPath);

            string output = "";
            int counter = 0;
            int byteAmount = 0;
            foreach (byte oneByte in byteArray)
            {
                output += (oneByte + ", ");
                counter++;
                if (counter == 64)
                {
                    counter = 0;
                    output += '\n';
                }
                byteAmount++;
            }
            saveFileDialog1.ShowDialog();
            string savePath = saveFileDialog1.FileName;
            File.WriteAllText(savePath, output);
            richTextBox1.Text += byteAmount;
        }

        public static Bitmap GetImageFromByteArray(byte[] byteArray)
        {
            Bitmap bm = (Bitmap)_imageConverter.ConvertFrom(byteArray);

            if (bm != null && (bm.HorizontalResolution != (int)bm.HorizontalResolution ||
                               bm.VerticalResolution != (int)bm.VerticalResolution))
            {
                // Correct a strange glitch that has been observed in the test program when converting 
                //  from a PNG file image created by CopyImageToByteArray() - the dpi value "drifts" 
                //  slightly away from the nominal integer value
                bm.SetResolution((int)(bm.HorizontalResolution + 0.5f),
                                 (int)(bm.VerticalResolution + 0.5f));
            }

            return bm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] intArray = new[] { 0, 64, 13, 210, 29, 19, 14, 144, 11, 139, 18, 112, 16, 6, 9, 92, 0, 0, 8, 135, 0, 0, 
                11, 90, 8, 181, 0, 0, 8, 195, 10, 10, 13, 201, 10, 53, 8, 58, 9, 252, 1, 94, 4, 129, 2, 164, 1, 109, 2, 122, 
                1, 233, 1, 167, 0, 168, 1, 13, 2, 4, 0, 0, 0, 209 };
            byte[] byteArray = new byte[64];
            int sum = 0;
            for (int i = 0; i < 64; i++)
            {
                byteArray[i] = (byte)intArray[i];
                sum += intArray[i];
            }
            richTextBox1.Text += sum;
            //saveFileDialog1.ShowDialog();
            //string savePath = saveFileDialog1.FileName;
            //File.WriteAllBytes(savePath, byteArray);
            //pictureBox1.Image = (Bitmap)((new ImageConverter()).ConvertFrom(byteArray));;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string imagePath = openFileDialog1.FileName;
            byte[] byteArray = null;
            File.WriteAllBytes(imagePath, byteArray);
            string output = "";
            int counter = 0;
            foreach (byte oneByte in byteArray)
            {
                output += (oneByte + ", ");
                counter++;
                if (counter == 64)
                {
                    counter = 0;
                    output += '\n';
                }
            }
            saveFileDialog1.ShowDialog();
            string savePath = saveFileDialog1.FileName;
            File.WriteAllText(savePath, output);
        }
    }
}
