using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelLogowania
{
    public partial class Form1 : Form
    {
        ArrayList Users = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            Users.Add(new User("root", "root"));
            Users.Add(new User("haslo", "maslo"));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            foreach(User user in Users)
            {
                if((String.Compare(user.Login,log.Text)==0)&&(String.Compare(user.Password,pass.Text)==0))
                    {
                        f.login = user.Login;
                        f.zalogowany = true;
                    }
            }
            f.Show();
        }
    }
}
