using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_ArmedBandit
{
    public class Player
    {
        private int playerId;
        private string playerName;
        private string playerPassword;
        private int playerCash;
        private int playerTokens;

        public Player() { }

        public int PlayerId
        {
            get { return playerId; }
            set { playerId = value; }
        }
        public string PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public string PlayerPassword
        {
            get { return playerPassword; }
            set { playerPassword = value; }
        }
        public int PlayerCash
        {
            get { return playerCash; }
            set { playerCash = value; }
        }
        public int PlayerTokens
        {
            get { return playerTokens; }
            set { playerTokens = value; }
        }
    }
}
