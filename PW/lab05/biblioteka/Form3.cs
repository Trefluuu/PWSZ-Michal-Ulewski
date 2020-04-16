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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void delete_Click(object sender, EventArgs e)
        {
            MySqlConnection databaseConnection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=biblioteka");
            string usunZbazy = "DELETE from ksiazki WHERE ksiazki.id = " + book_id.Text + ";";
            databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(usunZbazy, databaseConnection);

            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Książka usunięta");
                }
                else
                {
                    MessageBox.Show("Książka nie została usunięta");
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
