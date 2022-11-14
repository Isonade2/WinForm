using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private int[,] feld;
        private void Init(int x, int y, int bomb)
        {
            feld = new int[x, y];
            feld[1, 1] = -1;
            feld[0, 0] = 1;
            feld[1, 0] = 2;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Init(5, 3, 4);
            Button[,] BTN = new Button[feld.GetLength(0), feld.GetLength(1)];
            for (int x = 0; x < feld.GetLength(0); x++)
            {
                for(int y=0; y < feld.GetLength(1); y++)
                {
                    BTN[x, y] = new Button();
                    BTN[x, y].Size = new Size(50, 50);
                    BTN[x, y].Left = x * 50;
                    BTN[x,y].Top = y * 50;
                    Controls.Add(BTN[x, y]);
                    BTN[x,y].Click += BTN_Click;
                    BTN[x, y].TabStop = false;
                }
            }

        }
        private void BTN_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int x = b.Left / 50;
            int y = b.Top / 50;
            if (feld[x, y] == -1)
                b.Text = "bomb";
            else if (feld[x, y] == 0)
                b.Text = "";
            else
                b.Text = "" + feld[x, y];
            b.Enabled = false;
        }
    }
}
