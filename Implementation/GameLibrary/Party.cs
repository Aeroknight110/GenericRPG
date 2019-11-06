using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameLibrary
{
    public class Roll : Mortal
    {
        public Bitmap Img { get; private set; }
        public float XpDropped { get; private set; }

        private static readonly Random rand = new Random();
        private static readonly List<string> names = new List<string>() {
      "Bob", "Dr. Light", "WallCrusher"
    };

        public Enemy(int level, Bitmap img) : base(RandName(), level)
        {
            Img = img;

            // weaken so player has a chance
            Health /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;
            Mana /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;
            Str /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;
            Def /= (float)rand.NextDouble() * (WEAKEN_MAX - WEAKEN_MIN) + WEAKEN_MIN;

            XpDropped = (float)rand.NextDouble() * (MAX_XP_DROP - MIN_XP_DROP) + MIN_XP_DROP;
        }

        public static string RandName()
        {
            return names[rand.Next(names.Count)];
        }
    }
}
