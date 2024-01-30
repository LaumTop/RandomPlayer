using System;
namespace new_Random_Player
{
    class NormalPlayer : Player
    {
        public NormalPlayer(Difficulty difficulty) : base(difficulty)
        {
            Random random = new Random();

            int doYouHave;
            bool youHave;
            int healthQuality;

            this.money = random.Next(50000, 150000);
            this.age = random.Next(18, 20);

            healthQuality = random.Next(1, 2);

            if (healthQuality == 1) this.health = "Good";
            else this.health = "Normal";

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
