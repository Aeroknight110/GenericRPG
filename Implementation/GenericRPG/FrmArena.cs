using GameLibrary;
using GenericRPG.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace GenericRPG
{
    public partial class FrmArena : Form
    {
        private Game game;
        private Character character;
        private Roll roll;
        private Rush rush;
        private Enemy enemy;
        private Random rand;
        float PartyDamage = 0;

        /// Counter for the animation timer
        public int _counter;

        /// Initalizes the different sounds
        static SoundPlayer soundOne = new SoundPlayer(@"Resources/attack.wav");
        static SoundPlayer soundTwo = new SoundPlayer(@"Resources/punch.wav");
        static SoundPlayer soundThree = new SoundPlayer(@"Resources/slap.wav");
        static SoundPlayer soundFour = new SoundPlayer(@"Resources/punches.wav");
        static SoundPlayer magicOne = new SoundPlayer(@"Resources/magic1.wav");
        static SoundPlayer magicTwo = new SoundPlayer(@"Resources/magic2.wav");
        static SoundPlayer magicThree = new SoundPlayer(@"Resources/magic3.wav");
        static SoundPlayer magicFour = new SoundPlayer(@"Resources/magic4.wav");
        /// Creates an array with the different sound options
        SoundPlayer[] listOfSounds = { soundOne, soundTwo, soundThree, soundFour };
        SoundPlayer[] listOfMagicSounds = { magicOne, magicTwo, magicThree, magicFour };

        public FrmArena()
        {
            InitializeComponent();

        }
        private void btnEndFight_Click(object sender, EventArgs e)
        {
            EndFight();
        }
        private void EndFight()
        {
            Game.GetGame().ChangeState(GameState.ON_MAP);
            Close();
        }
        private void FrmArena_Load(object sender, EventArgs e)
        {
            rand = new Random();

            game = Game.GetGame();
            character = game.Character;
            roll = game.Roll;
            rush = game.Rush;
            MidFightlabel.Text = "";
            


            enemy = new Enemy(rand.Next(character.Level + 1), Resources.enemyRedStanding);
            // stats
            UpdateStats();

            // pictures
            picCharacter.BackgroundImage = GenericRPG.Properties.Resources.characterStanding;
            //picCharacter.BackgroundImage = character.Pic.BackgroundImage;
            picEnemy.BackgroundImage = enemy.Img;

            // names
            lblPlayerName.Text = character.Name;
            lblEnemyName.Text = enemy.Name;

            if (character.ClassType == classSystem.ARCHER)
            {
                character.SimpleAttack(enemy);
            }

        }
        public void UpdateStats()
        {
            lblPlayerLevel.Text = character.Level.ToString();
            lblPlayerHealth.Text = Math.Round(character.Health).ToString();
            lblPlayerStr.Text = Math.Round(character.Str).ToString();
            lblPlayerDef.Text = Math.Round(character.Def).ToString();
            lblPlayerMana.Text = Math.Round(character.Mana).ToString();
            lblPlayerXp.Text = Math.Round(character.XP).ToString();
            lblPlayerGb.Text = Math.Round(character.Gb).ToString();
            lblPlayerPt.Text = Math.Round(character.Pt).ToString();


            lblEnemyLevel.Text = enemy.Level.ToString();
            lblEnemyHealth.Text = Math.Round(enemy.Health).ToString();
            lblEnemyStr.Text = Math.Round(enemy.Str).ToString();
            lblEnemyDef.Text = Math.Round(enemy.Def).ToString();
            lblEnemyMana.Text = Math.Round(enemy.Mana).ToString();

            lblPlayerHealth.Text = Math.Round(character.Health).ToString();
            lblEnemyHealth.Text = Math.Round(enemy.Health).ToString();
        }
        public void SimAtk(Mortal Attacker, Mortal Reciever)
        {
            if (Reciever.Health >= 0){
                UpdateStats();
                MakeSoundEffect();
                _counter = 0;
                tmrAnimation.Enabled = true;
                tmrAnimation.Start();
                float prevEnemyHealth = Reciever.Health;
                Attacker.SimpleAttack(Reciever);
                PartyDamage = +(float)Math.Round(prevEnemyHealth - Reciever.Health);
                MidFightlabel.Text += Attacker.Name + " attacked. ";
                if (enemy.Health <= 0)
                {
                    float X = enemy.XpDropped;
                    character.GainXP(X);
                    roll.GainXP(X);
                    rush.GainXP(X);
                    character.GainGb(enemy.GbDropped);
                    character.GainPt(enemy.PtDropped);
                   
                    MidFightlabel.Text += " Damage dealt by party = " + Math.Round(PartyDamage);
                    MidFightlabel.Visible = true;
                    lblEndFightMessage.Text = "You Gained " + Math.Round(enemy.XpDropped) + " xp and" + Math.Round(enemy.GbDropped) + " gb and" + Math.Round(enemy.PtDropped) + " Pt!";
                    lblEndFightMessage.Visible = true;
                    Refresh();
                    Thread.Sleep(1200);
                    EndFight();
                    LevelUpcheck();
                }
            }
        }
        public void MagAtk(Mortal Attacker, Mortal Reciever)
        {
            if (Reciever.Health >= 0)
            {
                if (Attacker.Mana >= 5)
                {
                    UpdateStats();
                    MakeMagicSoundEffect();
                    _counter = 0;
                    tmrAnimation.Enabled = true;
                    tmrAnimation.Start();
                    float prevEnemyHealth = Reciever.Health;
                    Attacker.MagicAttack(enemy);
                    float PartyDamage = +(float)Math.Round(prevEnemyHealth - Reciever.Health);
                    MidFightlabel.Text += Attacker.Name + " casted a Spell. ";
                    if (enemy.Health <= 0)
                    {
                        float X = enemy.XpDropped;
                        character.GainXP(X);
                        roll.GainXP(X);
                        rush.GainXP(X);
                        character.GainGb(enemy.GbDropped);
                        character.GainPt(enemy.PtDropped);
                        MidFightlabel.Text += " Damage dealt by party = " + Math.Round(PartyDamage);
                        MidFightlabel.Visible = true;
                        lblEndFightMessage.Text = "You Gained " + Math.Round(enemy.XpDropped) + " xp and" + Math.Round(enemy.GbDropped) + " gb and" + Math.Round(enemy.PtDropped) + " Pt!";
                        lblEndFightMessage.Visible = true;
                        Refresh();
                        Thread.Sleep(1200);
                        EndFight();
                        LevelUpcheck();
                    }
                }
                else
                {
                    SimAtk(Attacker, Reciever);
                }
            }
        }

        public void LevelUpcheck()
        {
            if (character.ShouldLevelUp)
            {
                FrmLevelUp frmLevelUp = new FrmLevelUp();
                frmLevelUp.Show();
                if (character.Level == 2)
                {

                    FrmClass f1 = new FrmClass();
                    f1.Show();
                }
            } 
            if (roll.ShouldLevelUp)
                {
                    FrmLevelUpRoll frmLevelUprl = new FrmLevelUpRoll();
                    frmLevelUprl.Show();

                }
                if (rush.ShouldLevelUp)
                {
                    FrmLevelUpRush frmLevelUpru = new FrmLevelUpRush();
                    frmLevelUpru.Show();

                }
            
        }
        private void btnSimpleAttack_Click(object sender, EventArgs e)
        {
            MidFightlabel.Text = "";
            MakeSoundEffect();
            _counter = 0;
            tmrAnimation.Enabled = true;
            tmrAnimation.Start();
            float prevEnemyHealth = enemy.Health;
            character.SimpleAttack(enemy, character.weapon);
            float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
            lblEnemyDamage.Text = enemyDamage.ToString();
            lblEnemyDamage.Visible = true;
            tmrEnemyDamage.Enabled = true;

            if (enemy.Health <= 0)
            {
                float X = enemy.XpDropped;
                character.GainXP(X);
                roll.GainXP(X);
                rush.GainXP(X);
                character.GainGb(enemy.GbDropped);
                character.GainPt(enemy.PtDropped);
                if(character.Pt !=0)
                {
                    character.charInv.addItem(2);
                    
                }
                lblEndFightMessage.Text = "You Gained " + Math.Round(enemy.XpDropped) + " xp and" + Math.Round(enemy.GbDropped) + " gb and" + Math.Round(enemy.PtDropped) + "Pt!";
                lblEndFightMessage.Visible = true;
                Refresh();
                Thread.Sleep(1200);
                EndFight();
                LevelUpcheck();
                
            }
            else
            {

                float prevPlayerHealth = character.Health;
                enemy.SimpleAttack(character);
                float playerDamage = (float)Math.Round(prevPlayerHealth - character.Health);
                lblPlayerDamage.ForeColor = Color.Red;
                lblPlayerDamage.Text = playerDamage.ToString();
                lblPlayerDamage.Visible = true;
                tmrPlayerDamage.Enabled = true;
                if (character.Health <= 0)
                {

                    if (character.undead)
                    {
                        UpdateStats();
                        character.Health = character.MaxHealth;
                    }
                    else
                    {
                        UpdateStats();
                        game.ChangeState(GameState.DEAD);
                        lblEndFightMessage.Text = "You Were Defeated!";
                        lblEndFightMessage.Visible = true;
                        Refresh();
                        Thread.Sleep(1200);
                        EndFight();
                        FrmGameOver frmGameOver = new FrmGameOver();
                        frmGameOver.Show();
                    }
                }
                else
                {
                    UpdateStats();
                    SimAtk(rush, enemy);
                    SimAtk(roll, enemy);
                    MidFightlabel.Text += " Damage dealt by party = " + Math.Round(PartyDamage);
                    MidFightlabel.Visible = true;
                    
                }
            }
        }

        private void btnMagicAttack_Click(object sender, EventArgs e)
        {
            MidFightlabel.Text = "";
            MakeMagicSoundEffect();
            _counter = 0;
            tmrAnimation.Enabled = true;
            tmrAnimation.Start();

            if (Game.GetGame().Character.Mana >= 5)
            {
                //Form2 f2 = new Form2();
                //f2.Show();
                float prevEnemyHealth = enemy.Health;
                character.MagicAttack(enemy);

                float enemyDamage = (float)Math.Round(prevEnemyHealth - enemy.Health);
                lblEnemyDamage.Text = enemyDamage.ToString();
                lblEnemyDamage.Visible = true;
                tmrEnemyDamage.Enabled = true;
                if (enemy.Health <= 0)
                {
                    float X = enemy.XpDropped;
                    character.GainXP(X);
                    roll.GainXP(X);
                    rush.GainXP(X);
                    character.GainGb(enemy.GbDropped);
                    character.GainPt(enemy.PtDropped);
                    lblEndFightMessage.Text = "You Gained " + Math.Round(enemy.XpDropped) + " xp and" + Math.Round(enemy.GbDropped) + " gb and" + Math.Round(enemy.PtDropped) + "Pt!";
                    lblEndFightMessage.Visible = true;
                    Refresh();
                    Thread.Sleep(1200);
                    EndFight();
                    LevelUpcheck();

                }

                else
                {
                    float prevPlayerHealth = character.Health;
                    enemy.SimpleAttack(character);
                    float playerDamage = (float)Math.Round(prevPlayerHealth - character.Health);
                    lblPlayerDamage.ForeColor = Color.Red;
                    lblPlayerDamage.Text = playerDamage.ToString();
                    lblPlayerDamage.Visible = true;
                    tmrPlayerDamage.Enabled = true;
                    if (character.Health <= 0)
                    {
                        if (character.undead)
                        {
                            UpdateStats();
                            character.Health = character.MaxHealth;
                        }
                        else
                        {
                            UpdateStats();
                            game.ChangeState(GameState.DEAD);
                            lblEndFightMessage.Text = "You Were Defeated!";
                            lblEndFightMessage.Visible = true;
                            Refresh();
                            Thread.Sleep(1200);
                            EndFight();
                            FrmGameOver frmGameOver = new FrmGameOver();
                            frmGameOver.Show();
                        }
                    }
                    else
                    {
                        UpdateStats();
                        MagAtk(roll, enemy);
                        MagAtk(rush, enemy);
                        MidFightlabel.Text += " Damage dealt by party = " + Math.Round(PartyDamage);
                        MidFightlabel.Visible = true;
                    }
                }
            }
        }
           
                  
               
            
        


        private void btnRun_Click(object sender, EventArgs e)
        {
            if (rand.NextDouble() < 0.25)
            {
                lblEndFightMessage.Text = "You Ran Like a Coward!";
                lblEndFightMessage.Visible = true;
                Refresh();
                Thread.Sleep(1200);
                EndFight();
            }
            else
            {
                enemy.SimpleAttack(character);
                UpdateStats();
            }
        }

        private void tmrPlayerDamage_Tick(object sender, EventArgs e)
        {
            lblPlayerDamage.Top -= 2;
            if (lblPlayerDamage.Top < 10)
            {
                lblPlayerDamage.Visible = false;
                tmrPlayerDamage.Enabled = false;
                lblPlayerDamage.Top = 52;
            }
        }

        private void tmrEnemyDamage_Tick(object sender, EventArgs e)
        {
            lblEnemyDamage.Top -= 2;
            if (lblEnemyDamage.Top < 10)
            {
                lblEnemyDamage.Visible = false;
                tmrEnemyDamage.Enabled = false;
                lblEnemyDamage.Top = 52;
            }
        }

        private void tmrPartyDamage_Tick(object sender, EventArgs e)
        {
            MidFightlabel.Top -= 2;
            if (MidFightlabel.Top < 10)
            {
                MidFightlabel.Visible = false;
                tmrEnemyDamage.Enabled = false;
                MidFightlabel.Top = 52;
            }
        }

        /// Randomly chooses a sound effect from the array of sounds each time the simple attack button is pressed
        public void MakeSoundEffect()
        {
            (listOfSounds[new Random().Next(0, listOfSounds.Length)]).Play();
        }

        /// Randomly chooses a magic sound effect from the array of sounds each time the magic attack button is pressed
        public void MakeMagicSoundEffect()
        {
            (listOfMagicSounds[new Random().Next(0, listOfMagicSounds.Length)]).Play();
        }

        /// Creates the appearance of the characters punching when Simple Attack is pressed
        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            _counter++;
            if (_counter <= 4)
            {
                picCharacter.BackgroundImage = GenericRPG.Properties.Resources.character;
                picEnemy.BackgroundImage = GenericRPG.Properties.Resources.enemyRed;
            }
            else
            {
                picCharacter.BackgroundImage = GenericRPG.Properties.Resources.characterStanding;
                picEnemy.BackgroundImage = GenericRPG.Properties.Resources.enemyRedStanding;
                tmrAnimation.Stop();
            }
        }



        private void tmrNoMana_Tick(object sender, EventArgs e)
        {

            label10.Top -= 2;
            if (label10.Top < 200)
            {
                label10.Visible = false;
                label10.Top = 255;
            }
        }

        private void BtnHeal_Click(object sender, EventArgs e)
        {
            if(character.Pt>0)
            {
                float maxPlayerHealth = character.MaxHealth;
                float prevPlayerHealth = character.Health;
                if(prevPlayerHealth + 15 >= maxPlayerHealth)
                {
                    return;
                }
                else{
                    float playerHeal = 15;
                    character.Heal(character);
                    
                    lblPlayerDamage.ForeColor = Color.Green;
                    lblPlayerDamage.Text = playerHeal.ToString();
                    lblPlayerDamage.Visible = true;
                    lblPlayerDamage.Enabled = true;
                    tmrPlayerDamage.Enabled = true;


                    character.UsePt(1);
                    UpdateStats();
                    
                
                }
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
     
    }
}