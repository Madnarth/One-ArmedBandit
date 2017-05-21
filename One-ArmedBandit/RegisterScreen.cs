using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_ArmedBandit
{
    public partial class RegisterScreen : Form
    {
        public RegisterScreen()
        {
            InitializeComponent();
        }

        private void RegisterScreen_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUserName.TextLength > 3 && txtPass.TextLength > 3)
                {
                    if (MBDB.CheckPlayerExist(txtUserName.Text) == false)
                    {
                        MBDB.AddPlayer(txtUserName.Text, txtPass.Text);
                        txtUserName.Text = "";
                        txtPass.Text = "";
                        MessageBox.Show("Player added correctly.");
                        this.Close();
                    }
                    else { MessageBox.Show("User already exist.", "Alert"); }
                }
                else { MessageBox.Show("Player name and password should have at least 4 characters.", "Alert"); }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void RegisterScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            (this.Owner as LoginScreen).Login_Load(this,null);
        }
    }
}
