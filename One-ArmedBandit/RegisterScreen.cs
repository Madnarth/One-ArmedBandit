using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                if (txtUserName.TextLength > 3 && txtPass.TextLength > 5)
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
                else { MessageBox.Show("Player name should have at least 4 characters and password 6 characters.", "Alert"); }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\u0008]");
            MatchCollection matches = regex.Matches(txtUserName.Text);
            if (matches.Count > 0)
            {
                txtUserName.Clear();
                MessageBox.Show("Only letters and figures are allowed", "Alert");
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-zA-Z0-9\u0008]"))
            {
                e.Handled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"[^a-zA-Z0-9\u0008\!\@\#\$\&]");
            MatchCollection matches = regex.Matches(txtPass.Text);
            if (matches.Count > 0)
            {
                txtPass.Clear();
                MessageBox.Show("Allowed letters:\na-z A-Z 0-9 ! @ # $ &", "Alert");
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"[^a-zA-Z0-9\u0008\!\@\#\$\&]"))
            {
                e.Handled = true;
            }
        }
    }
}
