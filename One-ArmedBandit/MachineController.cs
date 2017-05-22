using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace One_ArmedBandit
{
    public class MachineController
    {
        private int tokensPool;

        public int GetTokensPool()
        {
            return tokensPool;
        }
        public void ChangeTokensPool(int value, Label l1)
        {
            tokensPool += value;
            l1.Text = "Tokens in the pool: " + tokensPool.ToString();
        }

        public string GetActiveName(string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT PlayerName FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            string value = "blank";
            while (reader.Read())
            {
                value = reader["PlayerName"].ToString();
            }
            reader.Close();
            return value;
        }
        public int GetActiveCash(string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT Cash FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            string value = "blank";
            while (reader.Read())
            {
                value = reader["Cash"].ToString();
            }
            reader.Close();
            
            return Convert.ToInt32(value);
        }
        public int GetActiveTokens(string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT Cash FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            string value = "blank";
            while (reader.Read())
            {
                value = reader["Tokens"].ToString();
            }
            reader.Close();

            return Convert.ToInt32(value);
        }
        public void SetFruits(PictureBox p1, PictureBox p2, PictureBox p3)
        {
            var random = new Random();
            p1.Image = System.Drawing.Image.FromFile($"Fruit{random.Next(1, 4)}.png");
            p2.Image = System.Drawing.Image.FromFile($"Fruit{random.Next(1, 4)}.png");
            p3.Image = System.Drawing.Image.FromFile($"Fruit{random.Next(1, 4)}.png");
        }
        public void SetPlayer(Label l1, Label l2, Label l3, string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT Cash FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            l1.Text = "Player: " + GetActiveName(MBDB.activePlayer);
            l2.Text = "Cash: " + GetActiveCash(MBDB.activePlayer);
            l3.Text = "Tokens: " + GetActiveCash(MBDB.activePlayer);
        }
    }
}
