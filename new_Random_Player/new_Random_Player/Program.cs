using new_Random_Player;
using System;

class MainClass
{
    public static void Main(string[] args)
    {
        List<string> playerList = new List<string>();
        Difficulty difficulty;
        Console.WriteLine("Write difficulty ");
        string dif = Console.ReadLine();
        int playercount; 

        if (string.IsNullOrEmpty(dif))
        {
            throw new ArgumentNullException("Difficulty cant be null or empty", nameof(dif));
        }
        else
        {
            difficulty = new Difficulty(dif);
            Player player = new Player(difficulty);
        }


        Console.Write("Write player count: ");
        string writePlayerCount = Console.ReadLine();


        if (string.IsNullOrEmpty(writePlayerCount))
        {
            throw new ArgumentNullException("Player count cant be null or empty", nameof(writePlayerCount));
        }
        else
        {
            Console.Clear();

            playercount = int.Parse(writePlayerCount);

            if(dif == "easy")
            {
                for (int i = 1; i <= playercount; i++)
                {
                    string playerLine = "";
                    EasyPlayer player = new EasyPlayer(difficulty);
                    string[] data = player.sendPlayerData();

                    foreach (string item in data)
                    {
                        playerLine += item + "\n";
                    }
                    playerLine = $"{i}. Player\n " + playerLine + "\n";
                    playerList.Add(playerLine);
                }

                foreach (string allPlayers in playerList)
                {
                    Console.WriteLine(allPlayers);
                }
            }
            else if(dif == "normal")
            {
                for (int i = 1; i <= playercount; i++)
                {
                    string playerLine = "";
                    NormalPlayer player = new NormalPlayer(difficulty);
                    string[] data = player.sendPlayerData();

                    foreach (string item in data)
                    {
                        playerLine += item + "\n";
                    }
                    playerLine = $"{i}. Player\n " + playerLine + "\n";
                    playerList.Add(playerLine);
                }

                foreach (string allPlayers in playerList)
                {
                    Console.WriteLine(allPlayers);
                }
            }
            else
            {
                for (int i = 1; i <= playercount; i++)
                {
                    string playerLine = "";
                    HardPlayer player = new HardPlayer(difficulty);
                    string[] data = player.sendPlayerData();

                    foreach (string item in data)
                    {
                        playerLine += item + "\n";
                    }
                    playerLine = $"{i}. Player\n " + playerLine + "\n";
                    playerList.Add(playerLine);
                }

                foreach (string allPlayers in playerList)
                {
                    Console.WriteLine(allPlayers);
                }
            }

        }
    }
}