using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_3 //By Ginta
{
    public partial class Form1 : Form
    {
        string[][,] horses = new string[3][,]
  {
    new string[2,1] { { "Blue Jay" },{ "Not Again" } },
    new string[5,1] { { "Summers Night" }, { "Coriolanus" }, { "Blue Rinse" }, { "Silver Shadow" }, { "SLK" } },
    new string[4,1] { { "Purple Rain" }, { "Last Ditch" }, { "Forty Fives" }, {"Too Double" } }
};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRunner1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < horses.GetLength(0); i++)
            {
                for (int j = 0; j < horses[i].GetLength(1); j++)
                {
                    lstRunner1.Items.Add(horses[i][0,j]);
                }
            }
        }

        private void btnRunner2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < horses.GetLength(0); i++)
            {
                for (int j = 0; j < horses[i].GetLength(1); j++)
                {
                    lstRunner2.Items.Add(horses[i][1, j]);
                }
            }
        }

        private void btnRunner3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < horses.GetLength(0); i++)
            {
                for (int j = 0; j < horses[i].GetLength(1); j++)
                {
                    lstRunner3.Items.Add(horses[2][i, j]);
                }
            }
        }
    }
}
