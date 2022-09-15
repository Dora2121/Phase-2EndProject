using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2Projecct
{
    class OneDayTeam : Player, ITeam
    {
        public static List<Player> list = new List<Player>();
        public OneDayTeam()
        {
            list.Capacity = 11;
        }
        public void Add(Player player)
        {
            list.Add(player);
        }
        public void Remove(int playerId)
        {
            Player ply = null;

            foreach (var play in list)
            {
                if (play.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details has been removed successfully", play.PlayerId);
                    ply = play;
                }
                else if(play.PlayerId != playerId)
                {
                    Console.WriteLine("Players details was Empty");
                }
            }
            list.Remove(ply);
        }
        public Player GetPlayerById(int playerId)
        {
            Player ply = null;

            foreach (var play in list)
            {
                if (play.PlayerId == playerId)
                {
                    ply = play;
                    break;
                }
                else
                {
                    Console.WriteLine("PlayerID not found");
                }
            }
            return ply;
        }
        public Player GetPlayerByName(string playerName)
        {
            Player ply = null;

            foreach (var play in list)
            {
                if (play.PlayerName == playerName)
                {
                    ply = play;
                    break;
                }
                else
                {
                    Console.WriteLine("PlayerName not found");
                }
            }
            return ply;
        }

        public List<Player> GetAllPlayers()
        {
            return list;
        }
    }
}