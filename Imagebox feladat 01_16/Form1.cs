using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imagebox_feladat_01_16
{
    public partial class Form1 : Form
    {

        int sorokszama = 5;
        int oszlopokszama = 8;
        int buttonsize = 80;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sorokszama; i++)
            {
                for (int j = 0; j < oszlopokszama; j++)
                {
                    PictureBox picturebox = new PictureBox();
                    picturebox.SetBounds(j * buttonsize, i * buttonsize, buttonsize, buttonsize);
                    picturebox.SizeMode = PictureBoxSizeMode.StretchImage;
                    picturebox.Image = Image.FromFile("csillagok.jpg");
                    picturebox.Click += (o, s) =>
                    {
                        PictureBox kep = (PictureBox)o;
                        picturebox.Image = Image.FromFile("bolygo.jpg");
                    };
                    panel1.Controls.Add(picturebox);

                }
            }
        }
    }
}
