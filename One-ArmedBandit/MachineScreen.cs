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
        public MachineScreen()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MC.SetFruits(pictureBox1, pictureBox2, pictureBox3);
            MC.SetPlayer(labPlayerName, labCash, labTokens, MBDB.activePlayer);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MC.Spin(pictureBox1, pictureBox2, pictureBox3, labTokensPool);
            //MC.ChangeTokensPool(10, labTokensPool);
        }

        private void MachineScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MBDB.conn.Close();
        }
    }
}
