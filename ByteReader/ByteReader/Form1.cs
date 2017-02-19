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
            //foreach (byte oneByte in byteArray)
            //{
            //    richTextBox1.Text += (oneByte + ", "); 
            //}
            richTextBox1.Text += ("" + (((byteArray[0] << 8) & 0xFF00) | byteArray[1] & 0xFF));
        }
    }
}
