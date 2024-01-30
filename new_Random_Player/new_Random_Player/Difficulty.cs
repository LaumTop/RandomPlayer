using System;
using System.Xml.Linq;

namespace new_Random_Player
{
    class Difficulty
    {

        string difficulty { get; set; }

        public Difficulty(string diffulty)
        {
            this.difficulty = diffulty;
            diffulty.ToLower();
        }
    }
}
