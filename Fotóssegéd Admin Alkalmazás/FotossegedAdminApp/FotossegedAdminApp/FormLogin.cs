using ConnectToMysqlDatabase.Database;
using CryptSharp;
using Fotosseged.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotossegedAdminApp
{
    public partial class FormLogin : Form
    {
        private MySQLDatabaseInterface mdi;
        private DataTable userDT;

        public FormLogin()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Database d = new Database();
            mdi = d.kapcsolodas();
            mdi.open();
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            userDT = mdi.getToDataTable("SELECT username,password FROM user WHERE username = '" + username + "'");
            if (userDT.Rows.Count != 0)
            {
                foreach (DataRow row in userDT.Rows)
                {
                    if (Crypter.CheckPassword(password, row["password"].ToString()))
                    {
                        this.Hide();
                        FormGepek fg = new FormGepek();
                        fg.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Helytelen Jelszó!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Helytelen Felhasználónév!");
            }
        }
    }
}
