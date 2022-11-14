using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                try
                {
                    Bitmap bitmap = new Bitmap(pictureBox1.Image);
                    Color color = bitmap.GetPixel(e.X, e.Y);
                    label1.Text = $"RED : {color.R} GREEN : {color.G} BLUE : {color.B}";
                }
                catch (Exception)
                {
                }
            }
        }
    }

}
