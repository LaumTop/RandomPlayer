using System;


{
    public class Program
    {
        public bool hard = false;
        public bool normal = false;
        public bool easy = false;
        public string name;
        public int age;
        public int money;
        public bool driverlicense = false;
        public bool bike = false;
        public string health;
        public int PlayerCount;
        public int randomname;


        public static void DataGet()
        {
            Console.WriteLine("Выберите режим игры\n");
            Console.WriteLine("1. Easy\n2. Normal\n 3. Hard");
            string difficulty = Console.ReadLine("");

            switch (difficulty)
            {
                case "1":
                case "easy":
                case "Easy":
                    easy = true;
                    break;
                case "2":
                case "normal":
                case "Normal":
                    normal = true;
                    break;
                case "Hard":
                case "hard":
                case "3":
                    hard = true;
                    break;
                default:
                    Console.WriteLine("Неверно указан режим игры");
                    return;
                    break;
            }
            Console.Write("Введите количество игроков: ");
            int PlayerCount = int.Parse(Console.ReadLine());
            for (int i = 1; i <= PlayerCount; i++)
            {
                Random rnd = new Random();
                int randomname = rnd.Next(1, 4);
                switch (randomname)
                {
                    case 1:
                        name = "Адольф";
                        break;
                    case 2:
                        name = "Егор";
                        break;
                    case 3:
                        name = "Лёха";
                        break;
                }
                Console.WriteLine($"Имя игрока {i}: {name}");
            }
        }

        public static void Main(string[] args)
        {
            DataGet();
        }
    }
}