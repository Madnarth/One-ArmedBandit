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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
            MBDB.GetConnection();
        }

        public void Login_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("coin.png");

            listView1.Items.Clear();
            List<Player> playerList;
              playerList = MBDB.GetPlayer();
                if (playerList.Count > 0)
                {
                    Player player;
                    for (int i = 0; i < playerList.Count; i++)
                    {
                        player = playerList[i];
                        listView1.Items.Add(player.PlayerId.ToString());
                        listView1.Items[i].SubItems.Add(player.PlayerName);
                        listView1.Items[i].SubItems.Add(player.PlayerCash.ToString());
                        listView1.Items[i].SubItems.Add(player.PlayerTokens.ToString());
                    }
                }
                else { MessageBox.Show("There are no players in the database.", "Alert"); }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MBDB.LoginPlayer(txtUserName.Text, txtPass.Text) == true)
                {
                    DialogResult = DialogResult.OK;
                    MBDB.CreateActivePlayer(txtUserName.Text);
                }
                else { MessageBox.Show("Bad username or password.", "Alert"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.GetType().ToString()); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterScreen RS = new RegisterScreen();
            RS.Owner = this;
            RS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MBDB.conn.Close();
            this.Close();
        }

        private void buttCredits_Click(object sender, EventArgs e)
        {
            var CS = new CreditsScreen();
            CS.Show();
        }

        private void buttHints_Click(object sender, EventArgs e)
        {
            var HS = new HintsScreen();
            HS.Show();
        }
    }
}
