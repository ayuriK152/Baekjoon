using System;
using System.Collections.Generic;

namespace AlgorithmStudy
{
    class boj20006
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int p = int.Parse(input[0]), m = int.Parse(input[1]);
            List<Room> rooms = new List<Room>();

            for (int i = 0; i < p; i++)
            {
                input = Console.ReadLine().Split(' ');
                int l = int.Parse(input[0]);
                Room currentRoom = null;

                foreach (Room r in rooms)
                {
                    if (r.players.Count < m && Math.Abs(r.players[0].level - l) <= 10)
                    {
                        currentRoom = r;
                        break;
                    }
                }
                if (currentRoom == null)
                {
                    currentRoom = new Room(m);
                    rooms.Add(currentRoom);
                }

                currentRoom.players.Add(new Player(l, input[1]));
            }

            foreach (Room r in rooms)
            {
                r.players.Sort();
                if (r.players.Count == m)
                    Console.WriteLine("Started!");
                else
                    Console.WriteLine("Waiting!");
                foreach (Player player in r.players)
                    Console.WriteLine($"{player.level} {player.name}");
            }
        }

        public class Player : IComparable<Player>
        {
            public int level;
            public string name;

            public Player(int _level, string _name)
            {
                level = _level;
                name = _name;
            }

            int IComparable<Player>.CompareTo(Player other)
            {
                return name.CompareTo(other.name);
            }
        }

        public class Room
        {
            public List<Player> players;
            public int max;

            public Room(int _max)
            {
                max = _max;
                players = new List<Player>();
            }
        }
    }
}
