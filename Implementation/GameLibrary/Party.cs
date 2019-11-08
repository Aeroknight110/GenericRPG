using System;
using System.Collections.Generic;
using System.Drawing;

namespace GameLibrary
{
    public class Roll : Mortal
    {
        private new const float INIT_HEALTH = 30;
        private new const float INIT_STR = 5;
        private new const float INIT_DEF = 1;
        private new const float INIT_LUCK = 20;
        private new const float INIT_SPEED = 7;
        private new const float INIT_MANA = 40;

        public new const float LVLINC_HEALTH = 5;
        public new const float LVLINC_STR = 2;
        public new const float LVLINC_DEF = 1;
        public new const float LVLINC_LUCK = 2;
        public new const float LVLINC_SPEED = 1;
        public new const float LVLINC_MANA = 10;
        public Weapon Weapon { get; private set; }
        public float XP { get; private set; }
        public bool ShouldLevelUp { get; private set; }

        public void GainXP(float amount)
        {
            XP += amount;

            // every 50 experience points roll gain a level
            if ((int)XP / 65 >= Level)
            {
                ShouldLevelUp = true;
            }
        }
        public override void ResetStats()
        {
            Level = 1;
            MaxHealth = INIT_HEALTH;
            Health = MaxHealth;
            MaxMana = INIT_MANA;
            Mana = MaxMana;
            Str = INIT_STR;
            Def = INIT_DEF;
            Luck = INIT_LUCK;
            Speed = INIT_SPEED;
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
        private new const float INIT_HEALTH = 50;
        private new const float INIT_STR = 4;
        private new const float INIT_DEF = 4;
        private new const float INIT_LUCK = 10;
        private new const float INIT_SPEED = 7;
        private new const float INIT_MANA = 20;

        public new const float LVLINC_HEALTH = 20;
        public new const float LVLINC_STR = 4;
        public new const float LVLINC_DEF = 1;
        public new const float LVLINC_LUCK = 1;
        public new const float LVLINC_SPEED = 5;
        public new const float LVLINC_MANA = 3;
        public Weapon Weapon { get; private set; }
        public float XP { get; private set; }
        public bool ShouldLevelUp { get; private set; }
        public void GainXP(float amount)
        {
            XP += amount;

            // every 100 experience points you gain a level
            if ((int)XP / 135 >= Level)
            {
                ShouldLevelUp = true;
            }
        }
        public override void ResetStats()
        {
            Level = 1;
            MaxHealth = INIT_HEALTH;
            Health = MaxHealth;
            MaxMana = INIT_MANA;
            Mana = MaxMana;
            Str = INIT_STR;
            Def = INIT_DEF;
            Luck = INIT_LUCK;
            Speed = INIT_SPEED;
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
