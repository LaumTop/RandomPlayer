using System;

namespace new_Random_Player
{
    class EasyPlayer : Player
    {
        public EasyPlayer(Difficulty difficulty) : base(difficulty)
        {
            Random random = new Random();

            int doYouHave;
            bool youHave;

            this.health = "Good";
            this.money = random.Next(100000, 200000);
            this.age = random.Next(18, 20);

            for(int i = 0; i < 3; ++i)
            {

                doYouHave = random.Next(0, 2);

                if (doYouHave == 0) youHave = false;
                else youHave = true;

                if(i == 1)
                {
                    this.bike = youHave;
                }
                else if(i == 2) 
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
