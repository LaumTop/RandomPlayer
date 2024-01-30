using System;
using System.Collections.Generic;

namespace new_Random_Player
{
    class HardPlayer : Player
    {
        public HardPlayer(Difficulty difficulty) : base(difficulty)
        {
            Random random = new Random();

            int doYouHave;
            bool youHave;
            int healthQuality;

            this.money = random.Next(25000, 100000);
            this.age = random.Next(18, 20);

            healthQuality = random.Next(1, 3);

            if (healthQuality == 1) this.health = "Good";
            else if (healthQuality == 2) this.health = "Normal";
            else this.health = "Bad";

            for (int i = 0; i < 3; ++i)
            {

                doYouHave = random.Next(0, 2);

                if (doYouHave == 0) youHave = false;
                else youHave = true;

                if (i == 1)
                {
                    this.bike = youHave;
                }
                else if (i == 2)
                {
                    this.haveBikeLicense = youHave;
                }
                else
                {
                    this.driverLicense = youHave;
                }
            }
        }
    }
}
