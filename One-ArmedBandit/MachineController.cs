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
        #region hide
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
        #endregion
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
            if ((int)fruit[0] == 3) value = 5;

            if ((int)fruit[0] == 2 & (int)fruit[1] == 2) value = 10;
            if ((int)fruit[0] == 3 & (int)fruit[1] == 3) value = 10;

            if ((int)fruit[0] == 1 & (int)fruit[1] == 1 & (int)fruit[2] == 1) value = 20;
            if ((int)fruit[0] == 2 & (int)fruit[1] == 2 & (int)fruit[2] == 2) value = 30;
            if ((int)fruit[0] == 3 & (int)fruit[1] == 3 & (int)fruit[2] == 3) value = 50;
            ChangeTokensPool(value, l1);
        }
    }
}
