using System;
using System.Runtime.CompilerServices;

namespace new_Random_Player
{
    class Player
    {
        Difficulty difficulty { get; set; }

        private string name;
        protected int age;
        protected int money;
        protected bool driverLicense;
        protected bool bike = false;
        protected bool haveBikeLicense;
        protected string health;

        private string[] names = 
            [
                "Aleksey",
                "Domenic",
                "Noah",
                "Liam",
                "Ermin",
            ];
        public Player(Difficulty difficulty)
        {
            Random random = new Random();

            
            int namesLength = names.Length;
            int randomName = random.Next(0, namesLength);

            this.difficulty = difficulty;
            this.name = names[randomName];
        }
        public string[] sendPlayerData()
        {
            string[] data =
                [
                "Your name: " + this.name,
                "Age: " + this.age,
                "Money count is " + this.money,
                "You have driver license " + this.driverLicense,
                "You have bike " + this.bike,
                "You have bike license " + this.haveBikeLicense,
                "Your health is " + this.health
                ];
            return data;
        }
    }
}
