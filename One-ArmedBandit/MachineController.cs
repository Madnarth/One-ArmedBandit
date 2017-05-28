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
        private int bet = 1;
        private int sellCurrency = 5;
        private int buyCurrency = 10;
        public enum Fruits { f1 = 1, f2 = 2, f3 = 3 };

        public int GetTokensPool()
        {
            return tokensPool;
        }
        public void ChangeTokensPool(int value, Label l1)
        {
            tokensPool += value;
            l1.Text = "Tokens in the pool: " + tokensPool.ToString();
        }
        public int GetBet()
        {
            return bet;
        }
        public int GetSellCurrency()
        {
            return sellCurrency;
        }
        public int GetBuyCurrency()
        {
            return buyCurrency;
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
        public bool PlayerHaveTokens(string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT Tokens FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            int value = 0;
            while (reader.Read())
            {
                value += (int)reader["Tokens"];
            }
            reader.Close();

            if (value - GetBet() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PlayerHaveCash(string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT Cash FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            int value = 0;
            while (reader.Read())
            {
                value += (int)reader["Cash"];
            }
            reader.Close();

            if (value - GetBuyCurrency() >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetFruits(PictureBox p1, PictureBox p2, PictureBox p3)
        {
            var random = new Random();
            p1.Image = System.Drawing.Image.FromFile($"Fruit{random.Next(1, 4)}.png");
            p2.Image = System.Drawing.Image.FromFile($"Fruit{random.Next(1, 4)}.png");
            p3.Image = System.Drawing.Image.FromFile($"Fruit{random.Next(1, 4)}.png");
        }
        public void SetPicture(PictureBox picture, int value)
        {
            picture.Image = System.Drawing.Image.FromFile($"Fruit{value}.png");

        }
        public void SetPlayer(Label l1, Label l2, Label l3, string activePlayer)
        {
            var selStmt = new SqlCommand("SELECT PlayerName, Cash, Tokens FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                l1.Text = "Player: " + reader["PlayerName"].ToString();
                l2.Text = "Cash: " + reader["Cash"].ToString();
                l3.Text = "Tokens: " + reader["Tokens"].ToString();
            }
            reader.Close();
        }
        public void Spin(PictureBox p1, PictureBox p2, PictureBox p3, Label l1)
        {
            Fruits[] fruit = new Fruits[3];
            var random = new Random();

            for (int i = 0; i < 3; i++)
            {
                Array values = Enum.GetValues(typeof(Fruits));
                fruit[i] = (Fruits)values.GetValue(random.Next(values.Length));
            }
            ResolveResults(fruit, l1);
            p1.Image = System.Drawing.Image.FromFile($"Fruit{(int)fruit[0]}.png");
            p2.Image = System.Drawing.Image.FromFile($"Fruit{(int)fruit[1]}.png");
            p3.Image = System.Drawing.Image.FromFile($"Fruit{(int)fruit[2]}.png");
        }
        public void ResolveResults(Fruits[] fruit, Label l1)
        {
            int value = 0;
            if ((int)fruit[0] == 3) value = 1;

            if ((int)fruit[0] == 2 & (int)fruit[1] == 2) value = 1;
            if ((int)fruit[0] == 3 & (int)fruit[1] == 3) value = 2;

            if ((int)fruit[0] == 1 & (int)fruit[1] == 1 & (int)fruit[2] == 1) value = 1;
            if ((int)fruit[0] == 2 & (int)fruit[1] == 2 & (int)fruit[2] == 2) value = 3;
            if ((int)fruit[0] == 3 & (int)fruit[1] == 3 & (int)fruit[2] == 3) value = 5;
            ChangeTokensPool(value, l1);
        }
        public int CollectTokens(string activePlayer, Label l1)
        {
            int value = 0;
            var selStmt = new SqlCommand("SELECT Tokens FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                value += (int)reader["Tokens"];
            }
            reader.Close();
            value += GetTokensPool();
            ChangeTokensPool(GetTokensPool()*(-1), l1);
            return value;
        }
        public int PutTokens(string activePlayer)
        {
            int value = 0;
            var selStmt = new SqlCommand("SELECT Tokens FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                value += (int)reader["Tokens"];
            }
            reader.Close();
            if (value != 0)
            {
                return value - GetBet();
            }
            else
            {
                return value;
            }
        }
        public int RemoveTokens(string activePlayer)
        {
            int value = 0;
            var selStmt = new SqlCommand("SELECT Tokens FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                value += (int)reader["Tokens"];
            }
            reader.Close();
            if (value != 0)
            {
                return value - 1;
            }
            else
            {
                return value;
            }
        }
        public int AddTokens(string activePlayer)
        {
            int value = 0;
            var selStmt = new SqlCommand("SELECT Tokens FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                value += (int)reader["Tokens"];
            }
            reader.Close();
            return value + 1;
        }
        public int SellTokens(string activePlayer)
        {
            int value = 0;
            var selStmt = new SqlCommand("SELECT Cash FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                value += (int)reader["Cash"];
            }
            reader.Close();
            return value + GetSellCurrency();
        }
        public int BuyTokens(string activePlayer)
        {
            int value = 0;
            var selStmt = new SqlCommand("SELECT Cash FROM Player WHERE PlayerName = '" + activePlayer + "'", MBDB.conn);
            SqlDataReader reader = selStmt.ExecuteReader();
            while (reader.Read())
            {
                value += (int)reader["Cash"];
            }
            reader.Close();
            if (value - GetBuyCurrency() > 0)
            {
                return value - GetBuyCurrency();
            }
            else
            {
                return 0;
            }
        }
    }
}
