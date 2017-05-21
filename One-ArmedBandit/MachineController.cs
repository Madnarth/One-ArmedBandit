using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace One_ArmedBandit
{
    class MachineController
    {
        private int tokensPool;

        public int GetTokensPool()
        {
            return tokensPool;
        }
        public void ChangeTokensPool(int value)
        {
            tokensPool += value;
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
        //public string SetFruits()
        //{
        //    var random = new Random();
        //    var value = "";
        //    value = $"Fruit{random.Next(1,4)}.png";
        //    return value;
        //}
    }
}
