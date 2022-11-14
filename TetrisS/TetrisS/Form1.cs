using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisS
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                arr[i] = rnd.Next(2);
            }
            if (arr[0] == 0)
                button1.BackColor = Color.Red;
            else
                button1.BackColor = Color.Blue;
            if (arr[1] == 0)
                button2.BackColor = Color.Red;
            else
                button2.BackColor = Color.Blue;
            if (arr[2] == 0)
                button3.BackColor = Color.Red;
            else
                button3.BackColor = Color.Blue;
            if (arr[3] == 0)
                button4.BackColor = Color.Red;
            else
                button4.BackColor = Color.Blue;
            if (arr[4] == 0)
                button5.BackColor = Color.Red;
            else
                button5.BackColor = Color.Blue;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(button5.BackColor == Color.Red)
                {
                    button5.BackColor = button4.BackColor;
                    button4.BackColor = button3.BackColor;
                    button3.BackColor = button2.BackColor;
                    button2.BackColor = button1.BackColor;
                    makebuttoncolor();


                }
                else
                {
                    Application.Restart();
                    MessageBox.Show("gameover");
                }
            }
            if(e.KeyCode == Keys.Right)
            {
                if(button5.BackColor == Color.Blue)
                {
                    button5.BackColor = button4.BackColor;
                    button4.BackColor = button3.BackColor;
                    button3.BackColor = button2.BackColor;
                    button2.BackColor = button1.BackColor;
                    makebuttoncolor();
                }
                else
                { 
                    Application.Restart();
                    MessageBox.Show("gameover");
                }
            }
            if(e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Hi");
            }
        }
        private void makebuttoncolor()
        {
            Random rnd = new Random();
            int a = rnd.Next(0,2);
            if (a == 0)
                button1.BackColor = Color.Red;
            else
                button1.BackColor = Color.Blue;
            
        }
    }

}
