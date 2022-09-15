using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phase2Projecct
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter  1:To Add Player 2:To Remove Player by Id 3.Get Player By Id 4.Get Player by Name  5.Get All Players:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        OneDayTeam obj1 = new OneDayTeam();
                        if (OneDayTeam.list.Count <= OneDayTeam.list.Capacity)
                        {
                            Console.WriteLine("enter player id:");
                            obj1.PlayerId = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter player name");
                            obj1.PlayerName = Console.ReadLine();
                            Console.WriteLine("enter player age:");
                            obj1.PlayerAge = Convert.ToInt32(Console.ReadLine());
                            obj1.Add(obj1);
                        }
                        else
                        {
                            Console.WriteLine("you are not able to add more than 11 players to the team.");
                        }
                        break;
                    case 2:
                        OneDayTeam obj2 = new OneDayTeam();
                        Console.WriteLine("Enter PlayerID to Remove:");
                        int to_remove = Convert.ToInt32(Console.ReadLine());
                        obj2.Remove(to_remove);
                        break;
                    case 3:
                        OneDayTeam obj3 = new OneDayTeam();
                        Console.WriteLine("Enter PlayerID:");
                        int player_id = Convert.ToInt32(Console.ReadLine());
                        Player p = obj3.GetPlayerById(player_id);
                        Console.WriteLine("PlayerID: " + p.PlayerId);
                        Console.WriteLine("PlayerName: " + p.PlayerName);
                        Console.WriteLine("PlayerAge: " + p.PlayerAge);
                        break;
                    case 4:
                        OneDayTeam obj4 = new OneDayTeam();
                        Console.WriteLine("Enter Player Name:");
                        string name = Console.ReadLine();
                        Player p1 = obj4.GetPlayerByName(name);
                        Console.WriteLine("PlayerID: " + p1.PlayerId);
                        Console.WriteLine("PlayerName: " + p1.PlayerName);
                        Console.WriteLine("PlayerAge: " + p1.PlayerAge);
                        break;
                    case 5:
                        Console.WriteLine("All Players details:");
                        List<Player> print_all = new List<Player>();
                        OneDayTeam obj5 = new OneDayTeam();
                        print_all = obj5.GetAllPlayers();
                        foreach (var play in print_all)
                        {
                            Console.WriteLine("PlayerID: " + play.PlayerId);
                            Console.WriteLine("PlayerName: " + play.PlayerName);
                            Console.WriteLine("PlayerAge: " + play.PlayerAge);
                        }
                        break;
                    default:
                        Environment.Exit(0);
                        break;

                }
                Console.WriteLine("Do you want to continue (yes/no)?");
                string repeat = Console.ReadLine();
                if ((repeat == "yes") || (repeat == "y") || (repeat == "Y"))
                {
                    continue;
                }
                else if ((repeat == "no") || (repeat == "n") || (repeat == "N"))
                {
                    Environment.Exit(0);
                }

                Console.ReadLine();
            }

        }
    }

}

