using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oblicz_Click(object sender, EventArgs e)
        {
            wynik.ForeColor = Color.Black;
            if ((waga.Text != "") && (wzrost.Text != "") && (wiek.Text != ""))
            {
                int waga1 = Convert.ToInt32(waga.Text);
                int wzrost1 = Convert.ToInt32(wzrost.Text);
                int wiek1 = Convert.ToInt32(wiek.Text);
                if (men.Checked == true)
                {
                    double bmr = ((9.99 * waga1) + (6.25 * wzrost1) + (4.92 * wiek1)) + 5;
                    wynik.Text = bmr.ToString();
                    wynik.ForeColor = Color.Red;
                }
                if (kobieta.Checked == true)
                {
                    double bmr = ((9.99 * waga1) + (6.25 * wzrost1) + (4.92 * wiek1)) - 161;
                    wynik.Text = bmr.ToString();
                    wynik.ForeColor = Color.Red;
                }
            }
            else
            {
                wynik.Text = "Brak danych";
                wynik.ForeColor = Color.Red;
            }
        }

        private void wyczysc_Click(object sender, EventArgs e)
        {
            waga.Text = "";
            wzrost.Text = "";
            wiek.Text = "";
            wynik.Text = "";
        }

    }
}
