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
        public MachineScreen()
        {
            InitializeComponent();
        }

        // DECLARING TOTAL, BET AND CREDITS
        public static long credits = 100;
        public static long total = 0;
        public static int bet = 10;

        // DECLARING EACH ITEM
        public static int p1;
        public static int p2;
        public static int p3;

        private void Form1_Load(object sender, EventArgs e)
        {
            var MC = new MachineController();
            var rand = new Random();
            labPlayerName.Text = "Player: " + MC.GetActiveName(MBDB.activePlayer);
            labCash.Text = "Cash: " + MC.GetActiveCash(MBDB.activePlayer);
            labTokens.Text = "Tokens: " + MC.GetActiveCash(MBDB.activePlayer);
            pictureBox1.Image = Image.FromFile($"Fruit{rand.Next(1, 4)}.png");
            pictureBox2.Image = Image.FromFile($"Fruit{rand.Next(1, 4)}.png");
            pictureBox3.Image = Image.FromFile($"Fruit{rand.Next(1, 4)}.png");
        }

        // GENERATES RANDOM NUMBERS
        public static class IntUtil
        {
            private static Random random;

            private static void Init()
            {
                if (random == null) random = new Random();
            }
            public static int Random(int min, int max)
            {
                Init();
                return random.Next(min, max);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (credits >= bet)
            //{
            //    credits = credits - bet;
            //    label5.Text = "Credits: " + credits.ToString();

            //    for (var i = 0; i < 10; i++)
            //    {
            //        p1 = IntUtil.Random(1, 4);
            //        p2 = IntUtil.Random(1, 4);
            //        p3 = IntUtil.Random(1, 4);
            //    }

            //    if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
            //    pictureBox1.Image = Image.FromFile(p1.ToString() + ".png");

            //    if (pictureBox2.Image != null) pictureBox2.Image.Dispose();
            //    pictureBox2.Image = Image.FromFile(p2.ToString() + ".png");

            //    if (pictureBox3.Image != null) pictureBox3.Image.Dispose();
            //    pictureBox3.Image = Image.FromFile(p3.ToString() + ".png");

            //    total = 0;

            //    // GET RESULTS FROM PAYTABLE
            //    // CHECK IF 1, 2 OR 3 OCCURANCES
            //    if (p1 == 3) total = total + 5;

            //    if (p1 == 2 & p2 == 2) total = total + 10;
            //    if (p1 == 3 & p2 == 3) total = total + 10;

            //    if (p1 == 1 & p2 == 1 & p3 == 1) total = total + 20;
            //    if (p1 == 2 & p2 == 2 & p3 == 2) total = total + 30;
            //    if (p1 == 3 & p2 == 3 & p3 == 3) total = total + 50;

            //    credits = credits + total;
            //    label4.Text = "Win: " + total.ToString();
            //    label5.Text = "Credits: " + credits.ToString();
            //}
        }

        private void MachineScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MBDB.conn.Close();
        }
    }
}
