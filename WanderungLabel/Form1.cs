using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WanderungLabel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Top = 10;

            int wanderungZahl = 0; // Kontrolliert wie oft das Label nach unten gewandert ist

            do
            {
                for (int i = 10; i <= 300; i++)
                {
                    label1.Top = i;
                }
                wanderungZahl += 1;
            } while (wanderungZahl < 11);
        }



    }
}

