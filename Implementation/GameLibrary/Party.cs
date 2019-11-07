using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameLibrary
{
    public class Roll : Mortal
    {
        public Bitmap Img { get; private set; }
        public Weapon Weapon { get; private set; }
        public float XP { get; private set; }
        public bool ShouldLevelUp { get; private set; }
        public void GainXP(float amount)
        {
            XP += amount;

            // every 100 experience points you gain a level
            if ((int)XP / 100 >= Level)
            {
                ShouldLevelUp = true;
            }
        }

        public override void LevelUp()
        {
            base.LevelUp();
            ShouldLevelUp = false;
        }
        public Roll(int Level=1) : base("Roll", Level )
        {
           //Img = img;
           Weapon = new Weapon(1);
        }
        
    }
    public class Rush : Mortal
    {
        public Bitmap Img { get; private set; }
        public Weapon Weapon { get; private set; }
        public float XP { get; private set; }
        public bool ShouldLevelUp { get; private set; }
        public void GainXP(float amount)
        {
            XP += amount;

            // every 100 experience points you gain a level
            if ((int)XP / 100 >= Level)
            {
                ShouldLevelUp = true;
            }
        }

        public override void LevelUp()
        { 
            base.LevelUp();
            ShouldLevelUp = false;
        }
        public Rush(int level=1) : base("Rush", level)
        {
            //Img = img;
            Weapon = new Weapon(1);
        }

    }
}
