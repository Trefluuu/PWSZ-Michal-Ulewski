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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sort_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=biblioteka;";
            string query = "SELECT * FROM ksiazki";

            listBox1.Items.Clear();

            if (id.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.id ASC";
            if (autor.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.autor ASC";
            if (tytul.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.tytul ASC";
            if (wydawnictwo.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.wydawnictwo ASC";
            if (data_wydania_stara.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.data_wydania ASC";
            if (data_wydania_mloda.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.data_wydania DESC";
            if (dostepnosc.Checked == true) query = "SELECT * FROM ksiazki ORDER BY ksiazki.czy_dostepna ASC";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Udało się!");
                    while (reader.Read())
                    {

                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5) };
                        listBox1.Items.Add(row[0] + "  " +  row[1] + "  " + row[2] + "  " + row[3] + "  " + row[4] + "  " + row[5]);
                    }
                }
                else
                {
                    MessageBox.Show("Brak rekordów!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
