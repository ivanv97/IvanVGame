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


        /* Methods that initialize attributes after first/ second
         hero is instantiated */
        private void InitializeFirstHeroAttributes(Hero hero)
        {
            healthBarFirst.Value = (int)hero.HealthPoints;
            attackBarFirst.Value = (int)hero.AttackPoints;
            armorBarFirst.Value = (int)hero.ArmorPoints;
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
        }

        private void InitializeSecondHeroAttributes(Hero hero)
        {
            healthBarSecond.Value = (int)hero.HealthPoints;
            attackBarSecond.Value = (int)hero.AttackPoints;
            armorBarSecond.Value = (int)hero.ArmorPoints;
        }

        private void btnSelectWarriorFirst_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(1,'w');
            labelFirstHero.Text = "Warrior";
            HideControlsFirst();
            InitializeFirstHeroAttributes(engine.HeroFirst);
            pictureFirstHero.Image = IvanVGame.Properties.Resources.AC3L___Warrior;
        }

        private void btnSelectKnightFirst_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(1, 'k');
            labelFirstHero.Text = "Knight";
            HideControlsFirst();
            InitializeFirstHeroAttributes(engine.HeroFirst);
            pictureFirstHero.Image = IvanVGame.Properties.Resources.knight;
        }

        private void btnSelectAssassinFirst_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(1, 'a');
            labelFirstHero.Text = "Assassin";
            HideControlsFirst();
            InitializeFirstHeroAttributes(engine.HeroFirst);
            pictureFirstHero.Image = IvanVGame.Properties.Resources.ASSASSIN;
        }

        private void btnSelectMonkFirst_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(1, 'm');
            labelFirstHero.Text = "Monk";
            HideControlsFirst();
            InitializeFirstHeroAttributes(engine.HeroFirst);
            pictureFirstHero.Image = IvanVGame.Properties.Resources.monk;
        }

        private void btnSelectClumsyFirst_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(1, 'c');
            labelFirstHero.Text = "Clumsy";
            HideControlsFirst();
            InitializeFirstHeroAttributes(engine.HeroFirst);
            pictureFirstHero.Image = IvanVGame.Properties.Resources.Clumsy;
        }

        private void btnSelectWarriorSecond_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(2, 'w');
            labelSecondHero.Text = "Warrior";
            HideControlsSecond();
            InitializeSecondHeroAttributes(engine.HeroSecond);
            pictureSecondHero.Image = IvanVGame.Properties.Resources.AC3L___Warrior;
        }

        private void btnSelectKnightSecond_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(2, 'k');
            labelSecondHero.Text = "Knight";
            HideControlsSecond();
            InitializeSecondHeroAttributes(engine.HeroSecond);
            pictureSecondHero.Image = IvanVGame.Properties.Resources.knight;
        }

        private void btnSelectAssassinSecond_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(2, 'a');
            labelSecondHero.Text = "Assassin";
            HideControlsSecond();
            InitializeSecondHeroAttributes(engine.HeroSecond);
            pictureSecondHero.Image = IvanVGame.Properties.Resources.ASSASSIN;
        }

        private void btnSelectMonkSecond_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(2, 'm');
            labelSecondHero.Text = "Monk";
            HideControlsSecond();
            InitializeSecondHeroAttributes(engine.HeroSecond);
            pictureSecondHero.Image = IvanVGame.Properties.Resources.monk;
        }

        private void btnSelectClumsySecond_Click(object sender, EventArgs e)
        {
            engine.InitializeHero(2, 'c');
            labelSecondHero.Text = "Clumsy";
            HideControlsSecond();
            InitializeSecondHeroAttributes(engine.HeroSecond);
            pictureSecondHero.Image = IvanVGame.Properties.Resources.Clumsy;
        }

        /* Attack of first hero,
         * makes sword  and shield visible,
         * moves sword with timer tick method
         * and performs an attack */
        private void btnAttackOfFirstHero_Click(object sender, EventArgs e)
        {
            if (!engine.ReadyToStart())
            {
                MessageBox.Show("Hero not selected!", "Error!");
                return;
            }
            pictureSwordSecond.Visible = false;
            pictureShieldFirst.Visible = false;
            //Reset the location of the sword
            pictureSwordSecond.Location = new Point(SecondSwordX, pictureSwordSecond.Location.Y);
            pictureSwordFirst.Visible = true;
            pictureShieldSecond.Visible = true;
            timerSwordFirst.Enabled = true;

            engine.AttackInProgress(engine.HeroFirst, engine.HeroSecond);
            InitializeSecondHeroAttributes(engine.HeroSecond);//Reset attributes
            if (engine.HeroFirst is Clumsy) //Reset attributes if the attacking hero is Clumsy
            {
                InitializeFirstHeroAttributes(engine.HeroFirst);
            }
            btnAttackOfFirstHero.Enabled = false;//Disable attack button
            //if the hero wins
            if (engine.HeroSecond.HealthPoints == .0m)
            {
                btnAttackOfSecondHero.Enabled = false;
                MessageBox.Show("Hero one wins!", "Congratulations");
                btnNewGame.Visible = true;
                return;
            }
            btnAttackOfSecondHero.Enabled = true;//Second hero's turn
        }


        /* The same attack for the second hero */
        private void btnAttackOfSecondHero_Click(object sender, EventArgs e)
        {
            if (!engine.ReadyToStart())
            {
                MessageBox.Show("Hero not selected!", "Error!");
                return;
            }
            pictureShieldSecond.Visible = false;
            pictureSwordFirst.Visible = false;
            pictureSwordFirst.Location = new Point(FirstSwordX, pictureSwordFirst.Location.Y);            
            pictureSwordSecond.Visible = true;
            pictureShieldFirst.Visible = true;
            timerSwordSecond.Enabled = true;


            engine.AttackInProgress(engine.HeroSecond, engine.HeroFirst);
            InitializeFirstHeroAttributes(engine.HeroFirst);
            if (engine.HeroSecond is Clumsy)
            {
                InitializeSecondHeroAttributes(engine.HeroSecond);
            }
            btnAttackOfSecondHero.Enabled = false;
            if (engine.HeroFirst.HealthPoints == .0m)
            {
                btnAttackOfFirstHero.Enabled = false;
                MessageBox.Show("Hero two wins!", "Congratulations");
                btnNewGame.Visible = true;
                return;
            }
            btnAttackOfFirstHero.Enabled = true;
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
