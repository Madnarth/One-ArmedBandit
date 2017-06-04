using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace One_ArmedBandit
{
    public static class MBDB
    {
        public static SqlConnection conn;
        public static string activePlayer;
        public static void GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
            conn = new SqlConnection(connStr);
            conn.Open();
        }
        public static void AddPlayer(string playerName, string password)
        {
            string insStmt = "INSERT INTO Player (PlayerName, Password) VALUES (@playerName, @password)";
            var insCmd = new SqlCommand(insStmt, conn);
            insCmd.Parameters.AddWithValue("@playerName", playerName);
            insCmd.Parameters.AddWithValue("@password", password);

            try { insCmd.ExecuteNonQuery(); }
            catch (SqlException ex) { throw ex; }
            finally {  }
        }
        public static List<Player> GetPlayer()
        {
            var playerList = new List<Player>();
            string selStmt = "SELECT * FROM Player ORDER BY Cash DESC";
            var selCmd = new SqlCommand(selStmt, conn);
            try
            {
                var reader = selCmd.ExecuteReader();
                while (reader.Read())
                {
                    Player player = new Player();
                    player.PlayerId = (int)reader["PlayerId"];
                    player.PlayerName = reader["PlayerName"].ToString();
                    player.PlayerPassword = reader["Password"].ToString();
                    player.PlayerCash = (int)reader["Cash"];
                    player.PlayerTokens = (int)reader["Tokens"];
                    playerList.Add(player);
                }
                reader.Close();
            }
            catch(SqlException ex) { throw ex; }
            finally {  }
            return playerList;
        }
        public static bool LoginPlayer(string playerName, string password)
        {
            var selStmt = new SqlDataAdapter ("SELECT * FROM Player WHERE PlayerName = '"+ playerName +"' AND Password = '"+ password +"'", conn);
            var dt = new System.Data.DataTable();
            selStmt.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                activePlayer = playerName;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckPlayerExist(string playerName)
        {
            SqlDataAdapter selStmt = new SqlDataAdapter("SELECT * FROM Player WHERE PlayerName = '" + playerName + "'", conn);
            var dt = new System.Data.DataTable();
            selStmt.Fill(dt);
            if (dt.Rows.Count >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void CreateActivePlayer(string playerName)
        {
            var selStmt = new SqlDataAdapter("SELECT PlayerName, Cash, Tokens FROM Player WHERE PlayerName = '" + playerName + "'", conn);
            var activePlayer = new System.Data.DataTable();
            selStmt.Fill(activePlayer);
        }
        public static void ChangePlayerTokens(string playerName, int value)
        {
            String selStmt = "UPDATE Player SET Tokens = " + value + " WHERE PlayerName = '" + playerName + "'";
            var com = new SqlCommand(selStmt, conn);
            com.ExecuteNonQuery();
        }
        public static void ChangePlayerCash(string playerName, int value)
        {
            String selStmt = "UPDATE Player SET Cash = " + value + " WHERE PlayerName = '" + playerName + "'";
            var com = new SqlCommand(selStmt, conn);
            com.ExecuteNonQuery();
        }
    }
}
