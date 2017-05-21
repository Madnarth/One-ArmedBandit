using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace One_ArmedBandit
{
    public static class MBDB
    {
        public static SqlConnection conn;
        public static string activePlayer;
        public static void GetConnection()
        {
            //laptop string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Paweł\Documents\GitHub\Leja\One-ArmedBandit\One-ArmedBandit\MasterBase.mdf;Integrated Security=True;MultipleActiveResultSets=True";
            string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Dokumenty\GitHub\One-ArmedBandit\One-ArmedBandit\MasterBase.mdf;Integrated Security=True;MultipleActiveResultSets=True";
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
            string selStmt = "SELECT * FROM Player ORDER BY PlayerName";
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
    }
}
