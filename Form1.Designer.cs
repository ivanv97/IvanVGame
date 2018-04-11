namespace IvanVGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.labelFirstHero = new System.Windows.Forms.Label();
            this.labelSecondHero = new System.Windows.Forms.Label();
            this.btnAttackOfFirstHero = new System.Windows.Forms.Button();
            this.btnAttackOfSecondHero = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelHealthFirst = new System.Windows.Forms.Label();
            this.labelAttackFirst = new System.Windows.Forms.Label();
            this.labelArmorFirst = new System.Windows.Forms.Label();
            this.labelHealthSecond = new System.Windows.Forms.Label();
            this.labelAttackSecond = new System.Windows.Forms.Label();
            this.labelArmorSecond = new System.Windows.Forms.Label();
            this.btnSelectWarriorFirst = new System.Windows.Forms.Button();
            this.btnSelectKnightFirst = new System.Windows.Forms.Button();
            this.btnSelectAssassinFirst = new System.Windows.Forms.Button();
            this.btnSelectMonkFirst = new System.Windows.Forms.Button();
            this.btnSelectWarriorSecond = new System.Windows.Forms.Button();
            this.btnSelectKnightSecond = new System.Windows.Forms.Button();
            this.btnSelectAssassinSecond = new System.Windows.Forms.Button();
            this.btnSelectMonkSecond = new System.Windows.Forms.Button();
            this.labelSelectFirst = new System.Windows.Forms.Label();
            this.labelSelectSecond = new System.Windows.Forms.Label();
            this.healthBarFirst = new System.Windows.Forms.ProgressBar();
            this.attackBarFirst = new System.Windows.Forms.ProgressBar();
            this.armorBarFirst = new System.Windows.Forms.ProgressBar();
            this.healthBarSecond = new System.Windows.Forms.ProgressBar();
            this.attackBarSecond = new System.Windows.Forms.ProgressBar();
            this.armorBarSecond = new System.Windows.Forms.ProgressBar();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pictureShieldSecond = new System.Windows.Forms.PictureBox();
            this.pictureSwordSecond = new System.Windows.Forms.PictureBox();
            this.pictureShieldFirst = new System.Windows.Forms.PictureBox();
            this.pictureSwordFirst = new System.Windows.Forms.PictureBox();
            this.pictureSecondHero = new System.Windows.Forms.PictureBox();
            this.pictureFirstHero = new System.Windows.Forms.PictureBox();
            this.timerSwordFirst = new System.Windows.Forms.Timer(this.components);
            this.timerSwordSecond = new System.Windows.Forms.Timer(this.components);
            this.btnSelectClumsyFirst = new System.Windows.Forms.Button();
            this.btnSelectClumsySecond = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShieldSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSwordSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShieldFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSwordFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecondHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstHero)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFirstHero
            // 
            this.labelFirstHero.AutoSize = true;
            this.labelFirstHero.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstHero.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstHero.ForeColor = System.Drawing.Color.Maroon;
            this.labelFirstHero.Location = new System.Drawing.Point(54, 9);
            this.labelFirstHero.Name = "labelFirstHero";
            this.labelFirstHero.Size = new System.Drawing.Size(229, 46);
            this.labelFirstHero.TabIndex = 0;
            this.labelFirstHero.Text = "First Hero";
            // 
            // labelSecondHero
            // 
            this.labelSecondHero.AutoSize = true;
            this.labelSecondHero.BackColor = System.Drawing.Color.Transparent;
            this.labelSecondHero.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecondHero.ForeColor = System.Drawing.Color.Maroon;
            this.labelSecondHero.Location = new System.Drawing.Point(533, 9);
            this.labelSecondHero.Name = "labelSecondHero";
            this.labelSecondHero.Size = new System.Drawing.Size(265, 46);
            this.labelSecondHero.TabIndex = 1;
            this.labelSecondHero.Text = "Second Hero";
            // 
            // btnAttackOfFirstHero
            // 
            this.btnAttackOfFirstHero.BackColor = System.Drawing.Color.DarkGray;
            this.btnAttackOfFirstHero.Enabled = false;
            this.btnAttackOfFirstHero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAttackOfFirstHero.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttackOfFirstHero.ForeColor = System.Drawing.Color.Red;
            this.btnAttackOfFirstHero.Location = new System.Drawing.Point(12, 542);
            this.btnAttackOfFirstHero.Name = "btnAttackOfFirstHero";
            this.btnAttackOfFirstHero.Size = new System.Drawing.Size(151, 59);
            this.btnAttackOfFirstHero.TabIndex = 4;
            this.btnAttackOfFirstHero.Text = "Attack>>>";
            this.btnAttackOfFirstHero.UseVisualStyleBackColor = false;
            this.btnAttackOfFirstHero.Click += new System.EventHandler(this.btnAttackOfFirstHero_Click);
            // 
            // btnAttackOfSecondHero
            // 
            this.btnAttackOfSecondHero.BackColor = System.Drawing.Color.DarkGray;
            this.btnAttackOfSecondHero.Enabled = false;
            this.btnAttackOfSecondHero.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAttackOfSecondHero.Font = new System.Drawing.Font("Snap ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttackOfSecondHero.ForeColor = System.Drawing.Color.Red;
            this.btnAttackOfSecondHero.Location = new System.Drawing.Point(657, 542);
            this.btnAttackOfSecondHero.Name = "btnAttackOfSecondHero";
            this.btnAttackOfSecondHero.Size = new System.Drawing.Size(151, 59);
            this.btnAttackOfSecondHero.TabIndex = 5;
            this.btnAttackOfSecondHero.Text = "<<<Attack";
            this.btnAttackOfSecondHero.UseVisualStyleBackColor = false;
            this.btnAttackOfSecondHero.Click += new System.EventHandler(this.btnAttackOfSecondHero_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Colonna MT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(322, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "FIGHT";
            // 
            // labelHealthFirst
            // 
            this.labelHealthFirst.AutoSize = true;
            this.labelHealthFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthFirst.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHealthFirst.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelHealthFirst.Location = new System.Drawing.Point(109, 93);
            this.labelHealthFirst.Name = "labelHealthFirst";
            this.labelHealthFirst.Size = new System.Drawing.Size(54, 20);
            this.labelHealthFirst.TabIndex = 7;
            this.labelHealthFirst.Text = "Health:";
            // 
            // labelAttackFirst
            // 
            this.labelAttackFirst.AutoSize = true;
            this.labelAttackFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelAttackFirst.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttackFirst.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelAttackFirst.Location = new System.Drawing.Point(108, 129);
            this.labelAttackFirst.Name = "labelAttackFirst";
            this.labelAttackFirst.Size = new System.Drawing.Size(97, 20);
            this.labelAttackFirst.TabIndex = 8;
            this.labelAttackFirst.Text = "Attack points:";
            // 
            // labelArmorFirst
            // 
            this.labelArmorFirst.AutoSize = true;
            this.labelArmorFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelArmorFirst.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArmorFirst.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelArmorFirst.Location = new System.Drawing.Point(109, 165);
            this.labelArmorFirst.Name = "labelArmorFirst";
            this.labelArmorFirst.Size = new System.Drawing.Size(95, 20);
            this.labelArmorFirst.TabIndex = 9;
            this.labelArmorFirst.Text = "Armor points:";
            // 
            // labelHealthSecond
            // 
            this.labelHealthSecond.AutoSize = true;
            this.labelHealthSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelHealthSecond.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHealthSecond.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelHealthSecond.Location = new System.Drawing.Point(508, 93);
            this.labelHealthSecond.Name = "labelHealthSecond";
            this.labelHealthSecond.Size = new System.Drawing.Size(54, 20);
            this.labelHealthSecond.TabIndex = 10;
            this.labelHealthSecond.Text = "Health:";
            // 
            // labelAttackSecond
            // 
            this.labelAttackSecond.AutoSize = true;
            this.labelAttackSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelAttackSecond.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttackSecond.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelAttackSecond.Location = new System.Drawing.Point(508, 129);
            this.labelAttackSecond.Name = "labelAttackSecond";
            this.labelAttackSecond.Size = new System.Drawing.Size(97, 20);
            this.labelAttackSecond.TabIndex = 11;
            this.labelAttackSecond.Text = "Attack points:";
            // 
            // labelArmorSecond
            // 
            this.labelArmorSecond.AutoSize = true;
            this.labelArmorSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelArmorSecond.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArmorSecond.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelArmorSecond.Location = new System.Drawing.Point(508, 165);
            this.labelArmorSecond.Name = "labelArmorSecond";
            this.labelArmorSecond.Size = new System.Drawing.Size(95, 20);
            this.labelArmorSecond.TabIndex = 12;
            this.labelArmorSecond.Text = "Armor points:";
            // 
            // btnSelectWarriorFirst
            // 
            this.btnSelectWarriorFirst.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSelectWarriorFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectWarriorFirst.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectWarriorFirst.Location = new System.Drawing.Point(44, 271);
            this.btnSelectWarriorFirst.Name = "btnSelectWarriorFirst";
            this.btnSelectWarriorFirst.Size = new System.Drawing.Size(81, 39);
            this.btnSelectWarriorFirst.TabIndex = 13;
            this.btnSelectWarriorFirst.Text = "Warrior";
            this.btnSelectWarriorFirst.UseVisualStyleBackColor = false;
            this.btnSelectWarriorFirst.Click += new System.EventHandler(this.btnSelectWarriorFirst_Click);
            // 
            // btnSelectKnightFirst
            // 
            this.btnSelectKnightFirst.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelectKnightFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectKnightFirst.ForeColor = System.Drawing.Color.Gold;
            this.btnSelectKnightFirst.Location = new System.Drawing.Point(44, 316);
            this.btnSelectKnightFirst.Name = "btnSelectKnightFirst";
            this.btnSelectKnightFirst.Size = new System.Drawing.Size(81, 39);
            this.btnSelectKnightFirst.TabIndex = 14;
            this.btnSelectKnightFirst.Text = "Knight";
            this.btnSelectKnightFirst.UseVisualStyleBackColor = false;
            this.btnSelectKnightFirst.Click += new System.EventHandler(this.btnSelectKnightFirst_Click);
            // 
            // btnSelectAssassinFirst
            // 
            this.btnSelectAssassinFirst.BackColor = System.Drawing.Color.Teal;
            this.btnSelectAssassinFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAssassinFirst.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSelectAssassinFirst.Location = new System.Drawing.Point(44, 361);
            this.btnSelectAssassinFirst.Name = "btnSelectAssassinFirst";
            this.btnSelectAssassinFirst.Size = new System.Drawing.Size(81, 39);
            this.btnSelectAssassinFirst.TabIndex = 15;
            this.btnSelectAssassinFirst.Text = "Assassin";
            this.btnSelectAssassinFirst.UseVisualStyleBackColor = false;
            this.btnSelectAssassinFirst.Click += new System.EventHandler(this.btnSelectAssassinFirst_Click);
            // 
            // btnSelectMonkFirst
            // 
            this.btnSelectMonkFirst.BackColor = System.Drawing.Color.Peru;
            this.btnSelectMonkFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectMonkFirst.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSelectMonkFirst.Location = new System.Drawing.Point(44, 406);
            this.btnSelectMonkFirst.Name = "btnSelectMonkFirst";
            this.btnSelectMonkFirst.Size = new System.Drawing.Size(81, 39);
            this.btnSelectMonkFirst.TabIndex = 16;
            this.btnSelectMonkFirst.Text = "Monk";
            this.btnSelectMonkFirst.UseVisualStyleBackColor = false;
            this.btnSelectMonkFirst.Click += new System.EventHandler(this.btnSelectMonkFirst_Click);
            // 
            // btnSelectWarriorSecond
            // 
            this.btnSelectWarriorSecond.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnSelectWarriorSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectWarriorSecond.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelectWarriorSecond.Location = new System.Drawing.Point(698, 271);
            this.btnSelectWarriorSecond.Name = "btnSelectWarriorSecond";
            this.btnSelectWarriorSecond.Size = new System.Drawing.Size(81, 39);
            this.btnSelectWarriorSecond.TabIndex = 20;
            this.btnSelectWarriorSecond.Text = "Warrior";
            this.btnSelectWarriorSecond.UseVisualStyleBackColor = false;
            this.btnSelectWarriorSecond.Click += new System.EventHandler(this.btnSelectWarriorSecond_Click);
            // 
            // btnSelectKnightSecond
            // 
            this.btnSelectKnightSecond.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelectKnightSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectKnightSecond.ForeColor = System.Drawing.Color.Gold;
            this.btnSelectKnightSecond.Location = new System.Drawing.Point(698, 316);
            this.btnSelectKnightSecond.Name = "btnSelectKnightSecond";
            this.btnSelectKnightSecond.Size = new System.Drawing.Size(81, 39);
            this.btnSelectKnightSecond.TabIndex = 19;
            this.btnSelectKnightSecond.Text = "Knight";
            this.btnSelectKnightSecond.UseVisualStyleBackColor = false;
            this.btnSelectKnightSecond.Click += new System.EventHandler(this.btnSelectKnightSecond_Click);
            // 
            // btnSelectAssassinSecond
            // 
            this.btnSelectAssassinSecond.BackColor = System.Drawing.Color.Teal;
            this.btnSelectAssassinSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectAssassinSecond.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSelectAssassinSecond.Location = new System.Drawing.Point(698, 361);
            this.btnSelectAssassinSecond.Name = "btnSelectAssassinSecond";
            this.btnSelectAssassinSecond.Size = new System.Drawing.Size(81, 39);
            this.btnSelectAssassinSecond.TabIndex = 18;
            this.btnSelectAssassinSecond.Text = "Assassin";
            this.btnSelectAssassinSecond.UseVisualStyleBackColor = false;
            this.btnSelectAssassinSecond.Click += new System.EventHandler(this.btnSelectAssassinSecond_Click);
            // 
            // btnSelectMonkSecond
            // 
            this.btnSelectMonkSecond.BackColor = System.Drawing.Color.Peru;
            this.btnSelectMonkSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectMonkSecond.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSelectMonkSecond.Location = new System.Drawing.Point(698, 406);
            this.btnSelectMonkSecond.Name = "btnSelectMonkSecond";
            this.btnSelectMonkSecond.Size = new System.Drawing.Size(81, 39);
            this.btnSelectMonkSecond.TabIndex = 17;
            this.btnSelectMonkSecond.Text = "Monk";
            this.btnSelectMonkSecond.UseVisualStyleBackColor = false;
            this.btnSelectMonkSecond.Click += new System.EventHandler(this.btnSelectMonkSecond_Click);
            // 
            // labelSelectFirst
            // 
            this.labelSelectFirst.AutoSize = true;
            this.labelSelectFirst.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelectFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectFirst.ForeColor = System.Drawing.Color.Yellow;
            this.labelSelectFirst.Location = new System.Drawing.Point(24, 218);
            this.labelSelectFirst.Name = "labelSelectFirst";
            this.labelSelectFirst.Size = new System.Drawing.Size(120, 16);
            this.labelSelectFirst.TabIndex = 21;
            this.labelSelectFirst.Text = "Select first hero:";
            // 
            // labelSelectSecond
            // 
            this.labelSelectSecond.AutoSize = true;
            this.labelSelectSecond.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelSelectSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectSecond.ForeColor = System.Drawing.Color.Yellow;
            this.labelSelectSecond.Location = new System.Drawing.Point(662, 218);
            this.labelSelectSecond.Name = "labelSelectSecond";
            this.labelSelectSecond.Size = new System.Drawing.Size(146, 16);
            this.labelSelectSecond.TabIndex = 22;
            this.labelSelectSecond.Text = "Select second hero:";
            // 
            // healthBarFirst
            // 
            this.healthBarFirst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.healthBarFirst.ForeColor = System.Drawing.Color.DarkRed;
            this.healthBarFirst.Location = new System.Drawing.Point(216, 93);
            this.healthBarFirst.Maximum = 1000;
            this.healthBarFirst.Name = "healthBarFirst";
            this.healthBarFirst.Size = new System.Drawing.Size(77, 20);
            this.healthBarFirst.TabIndex = 23;
            // 
            // attackBarFirst
            // 
            this.attackBarFirst.Location = new System.Drawing.Point(216, 129);
            this.attackBarFirst.Maximum = 200;
            this.attackBarFirst.Name = "attackBarFirst";
            this.attackBarFirst.Size = new System.Drawing.Size(77, 20);
            this.attackBarFirst.TabIndex = 24;
            // 
            // armorBarFirst
            // 
            this.armorBarFirst.ForeColor = System.Drawing.Color.Gray;
            this.armorBarFirst.Location = new System.Drawing.Point(216, 165);
            this.armorBarFirst.Maximum = 200;
            this.armorBarFirst.Name = "armorBarFirst";
            this.armorBarFirst.Size = new System.Drawing.Size(77, 20);
            this.armorBarFirst.TabIndex = 25;
            // 
            // healthBarSecond
            // 
            this.healthBarSecond.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.healthBarSecond.ForeColor = System.Drawing.Color.DarkRed;
            this.healthBarSecond.Location = new System.Drawing.Point(612, 93);
            this.healthBarSecond.Maximum = 1000;
            this.healthBarSecond.Name = "healthBarSecond";
            this.healthBarSecond.Size = new System.Drawing.Size(77, 20);
            this.healthBarSecond.TabIndex = 26;
            // 
            // attackBarSecond
            // 
            this.attackBarSecond.Location = new System.Drawing.Point(612, 129);
            this.attackBarSecond.Maximum = 200;
            this.attackBarSecond.Name = "attackBarSecond";
            this.attackBarSecond.Size = new System.Drawing.Size(77, 20);
            this.attackBarSecond.TabIndex = 27;
            // 
            // armorBarSecond
            // 
            this.armorBarSecond.ForeColor = System.Drawing.Color.Gray;
            this.armorBarSecond.Location = new System.Drawing.Point(612, 165);
            this.armorBarSecond.Maximum = 200;
            this.armorBarSecond.Name = "armorBarSecond";
            this.armorBarSecond.Size = new System.Drawing.Size(77, 20);
            this.armorBarSecond.TabIndex = 28;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.ForestGreen;
            this.btnNewGame.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.White;
            this.btnNewGame.Location = new System.Drawing.Point(307, 473);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(196, 46);
            this.btnNewGame.TabIndex = 29;
            this.btnNewGame.Text = "NEW GAME";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pictureShieldSecond
            // 
            this.pictureShieldSecond.BackColor = System.Drawing.Color.Transparent;
            this.pictureShieldSecond.Image = ((System.Drawing.Image)(resources.GetObject("pictureShieldSecond.Image")));
            this.pictureShieldSecond.Location = new System.Drawing.Point(512, 271);
            this.pictureShieldSecond.Name = "pictureShieldSecond";
            this.pictureShieldSecond.Size = new System.Drawing.Size(140, 160);
            this.pictureShieldSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShieldSecond.TabIndex = 33;
            this.pictureShieldSecond.TabStop = false;
            this.pictureShieldSecond.Visible = false;
            // 
            // pictureSwordSecond
            // 
            this.pictureSwordSecond.BackColor = System.Drawing.Color.Transparent;
            this.pictureSwordSecond.Image = ((System.Drawing.Image)(resources.GetObject("pictureSwordSecond.Image")));
            this.pictureSwordSecond.Location = new System.Drawing.Point(658, 271);
            this.pictureSwordSecond.Name = "pictureSwordSecond";
            this.pictureSwordSecond.Size = new System.Drawing.Size(150, 115);
            this.pictureSwordSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSwordSecond.TabIndex = 32;
            this.pictureSwordSecond.TabStop = false;
            this.pictureSwordSecond.Visible = false;
            // 
            // pictureShieldFirst
            // 
            this.pictureShieldFirst.BackColor = System.Drawing.Color.Transparent;
            this.pictureShieldFirst.Image = ((System.Drawing.Image)(resources.GetObject("pictureShieldFirst.Image")));
            this.pictureShieldFirst.Location = new System.Drawing.Point(168, 271);
            this.pictureShieldFirst.Name = "pictureShieldFirst";
            this.pictureShieldFirst.Size = new System.Drawing.Size(140, 160);
            this.pictureShieldFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureShieldFirst.TabIndex = 31;
            this.pictureShieldFirst.TabStop = false;
            this.pictureShieldFirst.Visible = false;
            // 
            // pictureSwordFirst
            // 
            this.pictureSwordFirst.BackColor = System.Drawing.Color.Transparent;
            this.pictureSwordFirst.Image = ((System.Drawing.Image)(resources.GetObject("pictureSwordFirst.Image")));
            this.pictureSwordFirst.Location = new System.Drawing.Point(12, 271);
            this.pictureSwordFirst.Name = "pictureSwordFirst";
            this.pictureSwordFirst.Size = new System.Drawing.Size(150, 115);
            this.pictureSwordFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSwordFirst.TabIndex = 30;
            this.pictureSwordFirst.TabStop = false;
            this.pictureSwordFirst.Visible = false;
            // 
            // pictureSecondHero
            // 
            this.pictureSecondHero.BackColor = System.Drawing.Color.Transparent;
            this.pictureSecondHero.Location = new System.Drawing.Point(658, 187);
            this.pictureSecondHero.Name = "pictureSecondHero";
            this.pictureSecondHero.Size = new System.Drawing.Size(150, 349);
            this.pictureSecondHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSecondHero.TabIndex = 3;
            this.pictureSecondHero.TabStop = false;
            // 
            // pictureFirstHero
            // 
            this.pictureFirstHero.BackColor = System.Drawing.Color.Transparent;
            this.pictureFirstHero.Location = new System.Drawing.Point(12, 187);
            this.pictureFirstHero.Name = "pictureFirstHero";
            this.pictureFirstHero.Size = new System.Drawing.Size(150, 349);
            this.pictureFirstHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFirstHero.TabIndex = 2;
            this.pictureFirstHero.TabStop = false;
            // 
            // timerSwordFirst
            // 
            this.timerSwordFirst.Interval = 1;
            this.timerSwordFirst.Tick += new System.EventHandler(this.timerSwordFirst_Tick);
            // 
            // timerSwordSecond
            // 
            this.timerSwordSecond.Interval = 1;
            this.timerSwordSecond.Tick += new System.EventHandler(this.timerSwordSecond_Tick);
            // 
            // btnSelectClumsyFirst
            // 
            this.btnSelectClumsyFirst.BackColor = System.Drawing.Color.Tomato;
            this.btnSelectClumsyFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectClumsyFirst.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSelectClumsyFirst.Location = new System.Drawing.Point(44, 451);
            this.btnSelectClumsyFirst.Name = "btnSelectClumsyFirst";
            this.btnSelectClumsyFirst.Size = new System.Drawing.Size(81, 39);
            this.btnSelectClumsyFirst.TabIndex = 34;
            this.btnSelectClumsyFirst.Text = "Clumsy";
            this.btnSelectClumsyFirst.UseVisualStyleBackColor = false;
            this.btnSelectClumsyFirst.Click += new System.EventHandler(this.btnSelectClumsyFirst_Click);
            // 
            // btnSelectClumsySecond
            // 
            this.btnSelectClumsySecond.BackColor = System.Drawing.Color.Tomato;
            this.btnSelectClumsySecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectClumsySecond.ForeColor = System.Drawing.Color.AliceBlue;
            this.btnSelectClumsySecond.Location = new System.Drawing.Point(698, 451);
            this.btnSelectClumsySecond.Name = "btnSelectClumsySecond";
            this.btnSelectClumsySecond.Size = new System.Drawing.Size(81, 39);
            this.btnSelectClumsySecond.TabIndex = 35;
            this.btnSelectClumsySecond.Text = "Clumsy";
            this.btnSelectClumsySecond.UseVisualStyleBackColor = false;
            this.btnSelectClumsySecond.Click += new System.EventHandler(this.btnSelectClumsySecond_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::IvanVGame.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 638);
            this.Controls.Add(this.btnSelectClumsySecond);
            this.Controls.Add(this.btnSelectClumsyFirst);
            this.Controls.Add(this.pictureShieldSecond);
            this.Controls.Add(this.pictureSwordSecond);
            this.Controls.Add(this.pictureShieldFirst);
            this.Controls.Add(this.pictureSwordFirst);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.armorBarSecond);
            this.Controls.Add(this.attackBarSecond);
            this.Controls.Add(this.healthBarSecond);
            this.Controls.Add(this.armorBarFirst);
            this.Controls.Add(this.attackBarFirst);
            this.Controls.Add(this.healthBarFirst);
            this.Controls.Add(this.labelSelectSecond);
            this.Controls.Add(this.labelSelectFirst);
            this.Controls.Add(this.btnSelectWarriorSecond);
            this.Controls.Add(this.btnSelectKnightSecond);
            this.Controls.Add(this.btnSelectAssassinSecond);
            this.Controls.Add(this.btnSelectMonkSecond);
            this.Controls.Add(this.btnSelectMonkFirst);
            this.Controls.Add(this.btnSelectAssassinFirst);
            this.Controls.Add(this.btnSelectKnightFirst);
            this.Controls.Add(this.btnSelectWarriorFirst);
            this.Controls.Add(this.labelArmorSecond);
            this.Controls.Add(this.labelAttackSecond);
            this.Controls.Add(this.labelHealthSecond);
            this.Controls.Add(this.labelArmorFirst);
            this.Controls.Add(this.labelAttackFirst);
            this.Controls.Add(this.labelHealthFirst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttackOfSecondHero);
            this.Controls.Add(this.btnAttackOfFirstHero);
            this.Controls.Add(this.pictureSecondHero);
            this.Controls.Add(this.pictureFirstHero);
            this.Controls.Add(this.labelSecondHero);
            this.Controls.Add(this.labelFirstHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Arena";
            ((System.ComponentModel.ISupportInitialize)(this.pictureShieldSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSwordSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureShieldFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSwordFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSecondHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFirstHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFirstHero;
        private System.Windows.Forms.Label labelSecondHero;
        private System.Windows.Forms.PictureBox pictureFirstHero;
        private System.Windows.Forms.PictureBox pictureSecondHero;
        private System.Windows.Forms.Button btnAttackOfFirstHero;
        private System.Windows.Forms.Button btnAttackOfSecondHero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelHealthFirst;
        private System.Windows.Forms.Label labelAttackFirst;
        private System.Windows.Forms.Label labelArmorFirst;
        private System.Windows.Forms.Label labelHealthSecond;
        private System.Windows.Forms.Label labelAttackSecond;
        private System.Windows.Forms.Label labelArmorSecond;
        private System.Windows.Forms.Button btnSelectWarriorFirst;
        private System.Windows.Forms.Button btnSelectKnightFirst;
        private System.Windows.Forms.Button btnSelectAssassinFirst;
        private System.Windows.Forms.Button btnSelectMonkFirst;
        private System.Windows.Forms.Button btnSelectWarriorSecond;
        private System.Windows.Forms.Button btnSelectKnightSecond;
        private System.Windows.Forms.Button btnSelectAssassinSecond;
        private System.Windows.Forms.Button btnSelectMonkSecond;
        private System.Windows.Forms.Label labelSelectFirst;
        private System.Windows.Forms.Label labelSelectSecond;
        private System.Windows.Forms.ProgressBar healthBarFirst;
        private System.Windows.Forms.ProgressBar attackBarFirst;
        private System.Windows.Forms.ProgressBar armorBarFirst;
        private System.Windows.Forms.ProgressBar healthBarSecond;
        private System.Windows.Forms.ProgressBar attackBarSecond;
        private System.Windows.Forms.ProgressBar armorBarSecond;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.PictureBox pictureSwordFirst;
        private System.Windows.Forms.PictureBox pictureShieldFirst;
        private System.Windows.Forms.PictureBox pictureSwordSecond;
        private System.Windows.Forms.PictureBox pictureShieldSecond;
        private System.Windows.Forms.Timer timerSwordFirst;
        private System.Windows.Forms.Timer timerSwordSecond;
        private System.Windows.Forms.Button btnSelectClumsyFirst;
        private System.Windows.Forms.Button btnSelectClumsySecond;
    }
}

