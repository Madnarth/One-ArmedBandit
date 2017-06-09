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
    public partial class MachineScreen : Form
    {
        MachineController MC = new MachineController();
        private void RefreshScreen()
        {
            MC.SetPlayer(labPlayerName, labCash, labTokens, MBDB.activePlayer);
        }
        public MachineScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MC.SetFruits(pictureBox1, pictureBox2, pictureBox3);
            RefreshScreen();
            labBet.Text = "Current bet: " + MC.GetBet();
        }

        private void buttSpin_Click(object sender, EventArgs e)
        {
            if (MC.PlayerHaveTokens(MBDB.activePlayer) == true)
            {
                MBDB.ChangePlayerTokens(MBDB.activePlayer, MC.PutTokens(MBDB.activePlayer));
                MC.Spin(pictureBox1, pictureBox2, pictureBox3, labTokensPool);
                labAlert.Text = "Alert:";
                RefreshScreen();
            }
            else
            {
                labAlert.Text = labAlert.Text = "Alert: " + MC.GetAlert(1);
            }
        }

        private void MachineScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MC.GetTokensPool() > 0)
            {
                MBDB.ChangePlayerTokens(MBDB.activePlayer, MC.CollectTokens(MBDB.activePlayer, labTokensPool));
            }
            MBDB.conn.Close();
        }

        private void buttCollect_Click(object sender, EventArgs e)
        {
            if (MC.GetTokensPool() != 0)
            {
                MBDB.ChangePlayerTokens(MBDB.activePlayer, MC.CollectTokens(MBDB.activePlayer, labTokensPool));
                labAlert.Text = "Alert:";
                RefreshScreen();
            }
            else
            {
                labAlert.Text = labAlert.Text = "Alert: " + MC.GetAlert(3);
            }
        }

        private void buttSell_Click(object sender, EventArgs e)
        {
            if (MC.PlayerHaveTokens(MBDB.activePlayer) == true)
            {
                MBDB.ChangePlayerTokens(MBDB.activePlayer, MC.RemoveTokens(MBDB.activePlayer));
                MBDB.ChangePlayerCash(MBDB.activePlayer, MC.SellTokens(MBDB.activePlayer));
                labAlert.Text = "Alert:";
                RefreshScreen(); 
            }
            else
            {
                labAlert.Text = labAlert.Text = "Alert: " + MC.GetAlert(0);
            }
        }
        
        private void buttBuy_Click(object sender, EventArgs e)
        {
            if (MC.PlayerHaveCash(MBDB.activePlayer) == true)
            {
                MBDB.ChangePlayerTokens(MBDB.activePlayer, MC.AddTokens(MBDB.activePlayer));
                MBDB.ChangePlayerCash(MBDB.activePlayer, MC.BuyTokens(MBDB.activePlayer));
                labAlert.Text = "Alert:";
                RefreshScreen();
            }
            else
            {
                labAlert.Text = "Alert: " + MC.GetAlert(2);
            }
        }

        private void buttHints_Click(object sender, EventArgs e)
        {
            var HS = new HintsScreen();
            HS.Show();
        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    } 
}
