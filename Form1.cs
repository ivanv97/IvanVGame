using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IvanVGame
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        GameEngine engine = new GameEngine();

        //read-only property that holds the X coordinate of first sword picture
        private int FirstSwordX { get { return pictureSwordFirst.Location.X; } }

        //read-only property that holds the X coordinate of second sword picture
        private int SecondSwordX { get { return pictureSwordSecond.Location.X; } }
        
        /* Methods that hide controls after first/ second
         hero is instantiated */
        private void HideControlsFirst()
        {
            labelSelectFirst.Visible = false;
            btnSelectWarriorFirst.Visible = false;
            btnSelectKnightFirst.Visible = false;
            btnSelectAssassinFirst.Visible = false;
            btnSelectMonkFirst.Visible = false;
            btnSelectClumsyFirst.Visible = false;
        }

        private void HideControlsSecond()
        {
            labelSelectSecond.Visible = false;
            btnSelectWarriorSecond.Visible = false;
            btnSelectKnightSecond.Visible = false;
            btnSelectAssassinSecond.Visible = false;
            btnSelectMonkSecond.Visible = false;
            btnSelectClumsySecond.Visible = false;
        }


        /*Hero selection method for the buttons of first hero types
         and second hero types*/
        private void HeroSelection(int i, char ch)
        {            
            if (i==1)
            {
                engine.HeroFirst = engine.InitializeHero(ch);
                HideControlsFirst();
                InitializeFirstHeroAttributes(engine.HeroFirst);

                if (engine.RandomStart() == 1)
                {
                    btnAttackOfFirstHero.Enabled = true;
                    btnAttackOfSecondHero.Enabled = false;
                }
                else
                {
                    btnAttackOfFirstHero.Enabled = false;
                    btnAttackOfSecondHero.Enabled = true;
                }

                switch (ch)
                {
                    case 'w':
                        labelFirstHero.Text = "Warrior";
                        pictureFirstHero.Image = IvanVGame.Properties.Resources.AC3L___Warrior;
                        break;
                    case 'k':
                        labelFirstHero.Text = "Knight";
                        pictureFirstHero.Image = IvanVGame.Properties.Resources.knight;
                        break;
                    case 'a':
                        labelFirstHero.Text = "Assassin";
                        pictureFirstHero.Image = IvanVGame.Properties.Resources.ASSASSIN;
                        break;
                    case 'm':
                        labelFirstHero.Text = "Monk";
                        pictureFirstHero.Image = IvanVGame.Properties.Resources.monk;
                        break;
                    case 'c':
                        labelFirstHero.Text = "Clumsy";
                        pictureFirstHero.Image = IvanVGame.Properties.Resources.Clumsy;
                        break;

                }
            }
            else
            {
                engine.HeroSecond = engine.InitializeHero(ch);
                HideControlsSecond();
                InitializeSecondHeroAttributes(engine.HeroSecond);
                switch (ch)
                {
                    case 'w':
                        labelSecondHero.Text = "Warrior";
                        pictureSecondHero.Image = IvanVGame.Properties.Resources.AC3L___Warrior;
                        break;
                    case 'k':
                        labelSecondHero.Text = "Knight";
                        pictureSecondHero.Image = IvanVGame.Properties.Resources.knight;
                        break;
                    case 'a':
                        labelSecondHero.Text = "Assassin";
                        pictureSecondHero.Image = IvanVGame.Properties.Resources.ASSASSIN;
                        break;
                    case 'm':
                        labelSecondHero.Text = "Monk";
                        pictureSecondHero.Image = IvanVGame.Properties.Resources.monk;
                        break;
                    case 'c':
                        labelSecondHero.Text = "Clumsy";
                        pictureSecondHero.Image = IvanVGame.Properties.Resources.Clumsy;
                        break;

                }
            }
        }

        /* Methods that initialize attributes after first/ second
         hero is instantiated */
        private void InitializeFirstHeroAttributes(Hero hero)
        {
            healthBarFirst.Value = (int)hero.HealthPoints;
            attackBarFirst.Value = (int)hero.AttackPoints;
            armorBarFirst.Value = (int)hero.ArmorPoints;
        }

        private void InitializeSecondHeroAttributes(Hero hero)
        {
            healthBarSecond.Value = (int)hero.HealthPoints;
            attackBarSecond.Value = (int)hero.AttackPoints;
            armorBarSecond.Value = (int)hero.ArmorPoints;
        }

        private void btnSelectWarriorFirst_Click(object sender, EventArgs e)
        {
            HeroSelection(1, 'w');
        }

        private void btnSelectKnightFirst_Click(object sender, EventArgs e)
        {
            HeroSelection(1, 'k');
        }

        private void btnSelectAssassinFirst_Click(object sender, EventArgs e)
        {
            HeroSelection(1, 'a');
        }

        private void btnSelectMonkFirst_Click(object sender, EventArgs e)
        {
            HeroSelection(1, 'm');
        }

        private void btnSelectClumsyFirst_Click(object sender, EventArgs e)
        {
            HeroSelection(1, 'c');
        }

        private void btnSelectWarriorSecond_Click(object sender, EventArgs e)
        {
            HeroSelection(2, 'w'); 
        }

        private void btnSelectKnightSecond_Click(object sender, EventArgs e)
        {
            HeroSelection(2, 'k');
        }

        private void btnSelectAssassinSecond_Click(object sender, EventArgs e)
        {
            HeroSelection(2, 'a');
        }

        private void btnSelectMonkSecond_Click(object sender, EventArgs e)
        {
            HeroSelection(2, 'm');
        }

        private void btnSelectClumsySecond_Click(object sender, EventArgs e)
        {
            HeroSelection(2, 'c');
        }

        /* Attack of a hero,
        * makes sword  and shield visible,
        * moves sword with timer tick method
        * and performs an attack */
        private void Attack(Hero attackingHero, Hero attackedHero, int heroTurn)
        {
            if (!engine.ReadyToStart())
            {
                MessageBox.Show("Hero not selected!", "Error!");
                return;
            }

            engine.AttackInProgress(attackingHero, attackedHero);

            if (heroTurn == 1)
            {
                btnAttackOfFirstHero.Enabled = false;
                pictureSwordSecond.Visible = false;
                pictureShieldFirst.Visible = false;
                //Reset the location of the sword
                pictureSwordSecond.Location = new Point(SecondSwordX, pictureSwordSecond.Location.Y);
                pictureSwordFirst.Visible = true;
                pictureShieldSecond.Visible = true;
                timerSwordFirst.Enabled = true;
                InitializeSecondHeroAttributes(engine.HeroSecond);//Reset attributes
                btnAttackOfSecondHero.Enabled = true;
            }
            else
            {
                btnAttackOfSecondHero.Enabled = false;
                pictureShieldSecond.Visible = false;
                pictureSwordFirst.Visible = false;
                pictureSwordFirst.Location = new Point(FirstSwordX, pictureSwordFirst.Location.Y);
                pictureSwordSecond.Visible = true;
                pictureShieldFirst.Visible = true;
                timerSwordSecond.Enabled = true;
                InitializeFirstHeroAttributes(engine.HeroFirst);
                btnAttackOfFirstHero.Enabled = true;
            }

            /* Reset attributes if the attacking hero is Clumsy in case
             * he attacks himself */
            if (attackingHero is Clumsy)
            {
                InitializeFirstHeroAttributes(engine.HeroFirst);
                InitializeSecondHeroAttributes(engine.HeroSecond);
            }

            if (attackedHero.HealthPoints == .0m)
            {
                btnAttackOfFirstHero.Enabled = false;
                btnAttackOfSecondHero.Enabled = false;
                string message = heroTurn == 1 ? "Hero one wins!" : "Hero two wins!";
                MessageBox.Show(message, "Congratulations");
                btnNewGame.Visible = true;
                return;
            }

            
        }
               
        private void btnAttackOfFirstHero_Click(object sender, EventArgs e)
        {
            Attack(engine.HeroFirst, engine.HeroSecond, 1);
        }
                        
        private void btnAttackOfSecondHero_Click(object sender, EventArgs e)
        {
            Attack(engine.HeroSecond, engine.HeroFirst, 2);
        }

        /* Restart the forms app */
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
            btnNewGame.Visible = false;
        }

        /* Timers that are activated with interval of 1 millisecond,
         * when a hero performs an attack,
         * they move the sword right next to the shield.*/
        private void timerSwordFirst_Tick(object sender, EventArgs e)
        {
            if (pictureSwordFirst.Location.X <= pictureShieldSecond.Location.X - pictureShieldSecond.Size.Width)
            {
                pictureSwordFirst.Location = new Point(pictureSwordFirst.Location.X + 10, pictureSwordFirst.Location.Y);
            }
            else
            {
                timerSwordFirst.Enabled = false;
            }
        }

        private void timerSwordSecond_Tick(object sender, EventArgs e)
        {
            if (pictureSwordSecond.Location.X >= pictureShieldFirst.Location.X + pictureShieldFirst.Size.Width)
            {
                pictureSwordSecond.Location = new Point(pictureSwordSecond.Location.X - 10, pictureSwordSecond.Location.Y);
            }
            else
            {
                timerSwordSecond.Enabled = false;
            }
        }


    }
}
