using System;

namespace GameLibrary {
  public class Mortal {
    #region Constants
    private const float INIT_HEALTH = 50;
    private const float INIT_STR = 10;
    private const float INIT_DEF = 2;
    private const float INIT_LUCK = 2;
    private const float INIT_SPEED = 2;
    private const float INIT_MANA = 40;

    public const float LVLINC_HEALTH = 10;
    public const float LVLINC_STR = 1;
    public const float LVLINC_DEF = 1;
    public const float LVLINC_LUCK = 1;
    public const float LVLINC_SPEED = 2;
    public const float LVLINC_MANA = 5;

    private const float SIMPLEATTACK_RANDOM_AMT = 0.25f;
    #endregion

    public string Name { get; set; }
    public int Level { get; set; }
        public float MaxHealth { get; set; }
    public float Health { get; set; }
    public float MaxMana { get; set; }
    public float Mana { get; set; }
    public float Str { get; set; }
    public float Def { get; set; }
    public float Luck { get; set; }
    public float Speed { get; set; }



    private Random rand;

    public Mortal(string name, int level) {
      Name = name;
      ResetStats();
      SetLevel(level);
      rand = new Random();
    }
    public virtual void ResetStats() {
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
    public void SetLevel(int level) {
      for (int i = 1; i < level; i++) {
        LevelUp();
      }
    }
    public virtual void LevelUp() {
      // level increases
      Level++;

      // health and mana
      MaxHealth += LVLINC_HEALTH;
      MaxMana += LVLINC_MANA;
      Health = MaxHealth;
      Mana = MaxMana;

      // other stats
      Str += LVLINC_STR;
      Def += LVLINC_DEF;
      Luck += LVLINC_LUCK;
      Speed += LVLINC_SPEED;
    }
    public void RefillHealthAndMana() {
      Health = MaxHealth;
      Mana = MaxMana;
    }
    public void SimpleAttack(Mortal receiver, Weapon weapon = null) {
            Boolean dodge = false;
            Random random = new Random();
            if (receiver is GameLibrary.Character)
            {
                
                
                int randomNumber = random.Next(0, 100);
                if (Game.GetGame().Character.ClassType == classSystem.ARCHER)
                {
                    
                    if(Game.GetGame().Character.Luck*3>randomNumber)
                    {
                        dodge = true;
                    }
                    
                }
                else
                {
                    if (Game.GetGame().Character.Luck  > randomNumber)
                    {
                        dodge = true;
                    }
                }

            }

            if (!dodge)
            {

                float baseDamage = 0;
                float strCoeffient = 1.0f;
                switch (Game.GetGame().Character.ClassType)
                {

                    case classSystem.SCRUM:
                        strCoeffient = 1.0f;

                        break;

                    case classSystem.WARRIOR:

                        strCoeffient = 2.0f;
                        break;
                    case classSystem.MAGICIAN:

                        strCoeffient = 0.7f;
                        break;
                    case classSystem.ARCHER:
                        strCoeffient = 1.2f;


                        break;
                    default:
                        baseDamage = 0;

                        break;
                }
                baseDamage = Math.Abs(Str * strCoeffient - receiver.Def);
             
                if(Game.GetGame().Character.ClassType == classSystem.ARCHER)
                {
                    
                    if(Game.GetGame().Character.Luck > random.Next(0, 100))
                    {
                        Console.WriteLine(baseDamage);
                        baseDamage = baseDamage * (100f + 5.0f*Game.GetGame().Character.Luck) / 100.0f;
                        Console.WriteLine(baseDamage);
                    }
                }
                float randMax = 1 + SIMPLEATTACK_RANDOM_AMT;
                float randMin = 1 - SIMPLEATTACK_RANDOM_AMT;
                float randMult;
                if (weapon != null)
                    if (weapon.wID == 3)
                    {
                        randMult = (float)((rand.NextDouble() * (randMax - randMin)) + randMin * (float)weapon.damMod);
                        double chance = rand.NextDouble();
                        if (chance < .15)
                            randMult *= (float)2.0;
                    }
                    else
                        randMult = (float)((rand.NextDouble() * (randMax - randMin)) + randMin * (float)weapon.damMod);
                else
                {
                    randMult = (float)((rand.NextDouble() * (randMax - randMin)) + randMin);
                }



                if (receiver.Speed > 0)
                {

                }
                receiver.Health -= (baseDamage * randMult);


            }
            
    }

        public void MagicAttack(Mortal receiver)
        {
            float strCoeffient = 0.2f;
            float ManaCoeffient = 0.5f;
            if (Mana >= 5)
            {

                float baseDamage = 0;
                Mana = Mana - 5;
                switch (Game.GetGame().Character.ClassType)
                {
                    case classSystem.SCRUM:
                        strCoeffient = 0.5f;
                        ManaCoeffient = 0.3f;


                        break;

                    case classSystem.WARRIOR:
                        strCoeffient = 0.8f;
                        ManaCoeffient = 0.3f;
                        break;
                    case classSystem.MAGICIAN:
                        Mana = Mana - 5;
                        strCoeffient = 0.5f;
                        ManaCoeffient = 1.0f;
                        break;
                    case classSystem.ARCHER:
                        strCoeffient = 0.5f;
                        ManaCoeffient = 0.5f;


                        break;
                    default:
                        strCoeffient = 0.1f;
                        ManaCoeffient = 0.1f;
                        break;

                }
                baseDamage = Math.Abs(Str * strCoeffient + ManaCoeffient * MaxMana - receiver.Def);
                float randMax = 1 + SIMPLEATTACK_RANDOM_AMT;
                float randMin = 1 - SIMPLEATTACK_RANDOM_AMT;
                float randMult = (float)(rand.NextDouble() * (randMax - randMin)) + randMin;


                receiver.Health -= (baseDamage * randMult);
            }
            else
            {

                Console.WriteLine("YOU DONT HAVE ENOUGH MANA");
            }

          



        }
        public void Heal(Mortal receiver)
        {
            receiver.Health += 15;
        }


    }
}
