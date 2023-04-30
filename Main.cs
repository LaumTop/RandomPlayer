using System;

public class Program
{
    public static bool hard = false;
    public static bool normal = false;
    public static bool easy = false;
    public static string name = "";
    public static int age;
    public static int money;
    public static bool driverlicense = false;
    public static bool bike = false;
    public static string havebike = "";
    public static string havedriverlicense = "";
    public static string health = "";
    public static int PlayerCount;
    public static int randomname;
    public static int randomhealth;

    public static void RandomPlayer()
    {
        Console.Clear();
        Console.WriteLine("Выберите режим игры\n");
        Console.WriteLine("1. Easy\n2. Normal\n3. Hard"); 
        string difficulty = Console.ReadLine();

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
            case "3":
            case "Hard":
            case "hard":
                hard = true;
                break;
            default:
                Console.WriteLine("Неверно указан режим игры");
                return;
        }
        Console.Clear();
        Console.Write("Введите количество игроков: ");
        PlayerCount = int.Parse(Console.ReadLine());
        Console.Clear();
        if(bike == true)
        {
            havebike = "Имеется";
        }
        else if(bike == false)
        {
            havebike = "Нету";
        }
        if(driverlicense == true)
        {
            havedriverlicense = "Имеется";
        }
        if(driverlicense == false)
        {
            havedriverlicense = "Нету";
        }
        for (int i = 1; i <= PlayerCount; i++)
        {
            Random rnd = new Random();
            randomname = rnd.Next(1, 7); 
            if(hard == true)
            {
                age = rnd.Next(15, 18);
                money = rnd.Next(20000, 50000);
                randomhealth = rnd.Next(1 , 5);
                if(age < 18){
                    driverlicense = false;
                }
                else if (age == 18)
                {
                    int randomdriverlicensechange = rnd.Next(1, 10);
                    if(randomdriverlicensechange == 10)
                    {
                        driverlicense = true;
                    }
                }
                int randombikechange = rnd.Next(1, 10);
                if(randombikechange == 10)
                {
                    bike = true;
                }
            }

            else if (normal == true)
            {
                age = rnd.Next(16, 19);
                money = rnd.Next(30000, 60000);
                randomhealth = rnd.Next(1,4);
                if(age < 18){
                    driverlicense = false;
                }
                else if(age >= 18)
                {
                    int driverlicensechange = rnd.Next(1, 8);
                    if(driverlicensechange == 8)
                    {
                        driverlicense = true;
                    }
                }
                int randombikechange = rnd.Next(1, 8);
                if(randombikechange == 8)
                {
                    bike = true;
                }
            }

            else if (easy == true)
            {
                age = rnd.Next(18, 20);
                money = rnd.Next(50000, 80000);
                randomhealth = rnd.Next(1, 3);
                int randomdriverlicensechange = rnd.Next(1, 5);
                if(randomdriverlicensechange == 5)
                {
                    driverlicense = true;
                }
                int randombikechange = rnd.Next(1, 5);
                if(randombikechange == 5)
                {
                    bike = true;
                }
            }

            switch (randomhealth)
            {
                case 1:
                health = "Здоров как бык";
                break;
                case 2:
                health = "Здоров";
                break;
                case 3:
                health = "Тюбик";
                break;
                case 4:
                health = "3 степень ожирения";
                break;
                case 5:
                health = "Спид";
                break;
            }
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
                case 4:
                name = "Евгений";
                break;
                case 5:
                name = "Евлампий";
                break;
                case 6:
                name = "Алекс";
                break;
            }
            
            Console.WriteLine($"Имя игрока {i}: {name} \nВозраст: {age}\nДеньги: {money}\nЗдорове: {health}\nВелосипед: {havebike}\nПрава: {havedriverlicense}\n");
        }
    }

    public static void Main(string[] args)
    {
        Console.ReadLine();
        RandomPlayer();
        Console.ReadLine();
    }
}