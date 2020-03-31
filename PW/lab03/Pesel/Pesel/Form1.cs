using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pesel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pesel_TextChanged(object sender, EventArgs e)
        {
        }

        private void Spr_Click(object sender, EventArgs e)
        {
            if(Pesel.TextLength != 11)
            {
                Wynik.Text = "Zły PESEL";
            }
            else
            {
                int[] wagi = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                Int64 pesel = Int64.Parse(Pesel.Text.ToString());
                Int64 pom = pesel;
                long suma = 0;
                long reszta;
                for(int i=9; i >= 0; i--)
                {
                    pom = pom / 10;
                    reszta = pom % 10;
                    suma = suma + (reszta * wagi[i]);
                }
                if ((10 - (suma % 10)) == pesel % 10)
                {
                    Wynik.Text = "PESEL poprawny";
                }
                else
                {
                    Wynik.Text = "Zły PESEL";
                }
            }
        }
    }
}
