using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace biblioteka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=biblioteka");
            string dodajDoBazy = "INSERT INTO ksiazki (id, tytul, autor, wydawnictwo, data_wydania, czy_dostepna) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "');";
            databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(dodajDoBazy, databaseConnection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Książka dodana");
                }
                else
                {
                    MessageBox.Show("Książka nie dodana");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            databaseConnection.Close();
        }
    }
}
