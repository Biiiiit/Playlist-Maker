using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playlister
{
    public partial class Add_Song : Form
    {
        public Add_Song()
        {
            InitializeComponent();
        }

        private void btnUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.png; *.jpeg;)|*.jpg; *.png; *jpeg; ";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txtPicture.Text = open.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Copy(txtPicture.Text, Path.Combine("C:\\Users\\ruben\\source\\repos\\Playlister\\Playlister\\Album Covers\\", Path.GetFileName(txtPicture.Text)), true);
        }
    }
}
