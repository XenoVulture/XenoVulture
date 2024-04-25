
namespace AndrewRusso_CPT_185_Final_Project
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.enemyPic = new System.Windows.Forms.PictureBox();
            this.Card2 = new System.Windows.Forms.PictureBox();
            this.Card3 = new System.Windows.Forms.PictureBox();
            this.Card1 = new System.Windows.Forms.PictureBox();
            this.DeckBack = new System.Windows.Forms.PictureBox();
            this.Card4 = new System.Windows.Forms.PictureBox();
            this.Card6 = new System.Windows.Forms.PictureBox();
            this.Card5 = new System.Windows.Forms.PictureBox();
            this.enemyCurrentHealth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.maxEnergyLabel = new System.Windows.Forms.Label();
            this.currentEnergyLabel = new System.Windows.Forms.Label();
            this.enemyAttackTextBox = new System.Windows.Forms.TextBox();
            this.PassTurnButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maxHealthLabel = new System.Windows.Forms.Label();
            this.currentHealthLabel = new System.Windows.Forms.Label();
            this.clickDeckToDrawLabel = new System.Windows.Forms.Label();
            this.enemyNameLabel = new System.Windows.Forms.Label();
            this.card1NameLabel = new System.Windows.Forms.Label();
            this.card1TypeLabel = new System.Windows.Forms.Label();
            this.card1ValueLabel = new System.Windows.Forms.Label();
            this.card2ValueLabel = new System.Windows.Forms.Label();
            this.card2TypeLabel = new System.Windows.Forms.Label();
            this.card2NameLabel = new System.Windows.Forms.Label();
            this.card3ValueLabel = new System.Windows.Forms.Label();
            this.card3TypeLabel = new System.Windows.Forms.Label();
            this.card3NameLabel = new System.Windows.Forms.Label();
            this.card4ValueLabel = new System.Windows.Forms.Label();
            this.card4TypeLabel = new System.Windows.Forms.Label();
            this.card4NameLabel = new System.Windows.Forms.Label();
            this.card5ValueLabel = new System.Windows.Forms.Label();
            this.card5TypeLabel = new System.Windows.Forms.Label();
            this.card5NameLabel = new System.Windows.Forms.Label();
            this.card6ValueLabel = new System.Windows.Forms.Label();
            this.card6TypeLabel = new System.Windows.Forms.Label();
            this.card6NameLabel = new System.Windows.Forms.Label();
            this.playerCardImages = new System.Windows.Forms.ImageList(this.components);
            this.enemyImages = new System.Windows.Forms.ImageList(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.blockLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.damageUpLabel = new System.Windows.Forms.Label();
            this.mixtureCounterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeckBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // enemyPic
            // 
            this.enemyPic.Image = ((System.Drawing.Image)(resources.GetObject("enemyPic.Image")));
            this.enemyPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("enemyPic.InitialImage")));
            this.enemyPic.Location = new System.Drawing.Point(620, 27);
            this.enemyPic.Name = "enemyPic";
            this.enemyPic.Size = new System.Drawing.Size(175, 230);
            this.enemyPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemyPic.TabIndex = 1;
            this.enemyPic.TabStop = false;
            // 
            // Card2
            // 
            this.Card2.Image = ((System.Drawing.Image)(resources.GetObject("Card2.Image")));
            this.Card2.InitialImage = ((System.Drawing.Image)(resources.GetObject("Card2.InitialImage")));
            this.Card2.Location = new System.Drawing.Point(238, 288);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(195, 256);
            this.Card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card2.TabIndex = 5;
            this.Card2.TabStop = false;
            this.Card2.Click += new System.EventHandler(this.Card2_Click);
            // 
            // Card3
            // 
            this.Card3.Image = ((System.Drawing.Image)(resources.GetObject("Card3.Image")));
            this.Card3.InitialImage = ((System.Drawing.Image)(resources.GetObject("Card3.InitialImage")));
            this.Card3.Location = new System.Drawing.Point(464, 288);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(195, 256);
            this.Card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card3.TabIndex = 6;
            this.Card3.TabStop = false;
            this.Card3.Click += new System.EventHandler(this.Card3_Click);
            // 
            // Card1
            // 
            this.Card1.Image = ((System.Drawing.Image)(resources.GetObject("Card1.Image")));
            this.Card1.InitialImage = ((System.Drawing.Image)(resources.GetObject("Card1.InitialImage")));
            this.Card1.Location = new System.Drawing.Point(12, 288);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(195, 256);
            this.Card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card1.TabIndex = 7;
            this.Card1.TabStop = false;
            this.Card1.Click += new System.EventHandler(this.Card1_Click);
            // 
            // DeckBack
            // 
            this.DeckBack.Image = ((System.Drawing.Image)(resources.GetObject("DeckBack.Image")));
            this.DeckBack.InitialImage = ((System.Drawing.Image)(resources.GetObject("DeckBack.InitialImage")));
            this.DeckBack.Location = new System.Drawing.Point(620, 643);
            this.DeckBack.Name = "DeckBack";
            this.DeckBack.Size = new System.Drawing.Size(132, 177);
            this.DeckBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DeckBack.TabIndex = 10;
            this.DeckBack.TabStop = false;
            this.DeckBack.Click += new System.EventHandler(this.DeckBack_Click);
            // 
            // Card4
            // 
            this.Card4.Image = ((System.Drawing.Image)(resources.GetObject("Card4.Image")));
            this.Card4.InitialImage = ((System.Drawing.Image)(resources.GetObject("Card4.InitialImage")));
            this.Card4.Location = new System.Drawing.Point(690, 288);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(195, 256);
            this.Card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card4.TabIndex = 9;
            this.Card4.TabStop = false;
            this.Card4.Click += new System.EventHandler(this.Card4_Click);
            // 
            // Card6
            // 
            this.Card6.Image = ((System.Drawing.Image)(resources.GetObject("Card6.Image")));
            this.Card6.InitialImage = ((System.Drawing.Image)(resources.GetObject("Card6.InitialImage")));
            this.Card6.Location = new System.Drawing.Point(1142, 285);
            this.Card6.Name = "Card6";
            this.Card6.Size = new System.Drawing.Size(195, 256);
            this.Card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card6.TabIndex = 8;
            this.Card6.TabStop = false;
            this.Card6.Click += new System.EventHandler(this.Card6_Click);
            // 
            // Card5
            // 
            this.Card5.Image = ((System.Drawing.Image)(resources.GetObject("Card5.Image")));
            this.Card5.InitialImage = ((System.Drawing.Image)(resources.GetObject("Card5.InitialImage")));
            this.Card5.Location = new System.Drawing.Point(916, 285);
            this.Card5.Name = "Card5";
            this.Card5.Size = new System.Drawing.Size(195, 256);
            this.Card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Card5.TabIndex = 12;
            this.Card5.TabStop = false;
            this.Card5.Click += new System.EventHandler(this.Card5_Click);
            // 
            // enemyCurrentHealth
            // 
            this.enemyCurrentHealth.Location = new System.Drawing.Point(556, 53);
            this.enemyCurrentHealth.Name = "enemyCurrentHealth";
            this.enemyCurrentHealth.ReadOnly = true;
            this.enemyCurrentHealth.Size = new System.Drawing.Size(53, 23);
            this.enemyCurrentHealth.TabIndex = 17;
            this.enemyCurrentHealth.TabStop = false;
            this.toolTip1.SetToolTip(this.enemyCurrentHealth, "This is how much health the enemy has left");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HP:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.maxEnergyLabel);
            this.groupBox1.Controls.Add(this.currentEnergyLabel);
            this.groupBox1.Location = new System.Drawing.Point(758, 659);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(88, 60);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ENERGY";
            this.toolTip1.SetToolTip(this.groupBox1, "Each card costs 1 energy to play.");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "/";
            // 
            // maxEnergyLabel
            // 
            this.maxEnergyLabel.AutoSize = true;
            this.maxEnergyLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxEnergyLabel.Location = new System.Drawing.Point(55, 26);
            this.maxEnergyLabel.Name = "maxEnergyLabel";
            this.maxEnergyLabel.Size = new System.Drawing.Size(28, 31);
            this.maxEnergyLabel.TabIndex = 31;
            this.maxEnergyLabel.Text = "9";
            // 
            // currentEnergyLabel
            // 
            this.currentEnergyLabel.AutoSize = true;
            this.currentEnergyLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentEnergyLabel.Location = new System.Drawing.Point(4, 26);
            this.currentEnergyLabel.Name = "currentEnergyLabel";
            this.currentEnergyLabel.Size = new System.Drawing.Size(28, 31);
            this.currentEnergyLabel.TabIndex = 29;
            this.currentEnergyLabel.Text = "9";
            // 
            // enemyAttackTextBox
            // 
            this.enemyAttackTextBox.Location = new System.Drawing.Point(556, 85);
            this.enemyAttackTextBox.Name = "enemyAttackTextBox";
            this.enemyAttackTextBox.ReadOnly = true;
            this.enemyAttackTextBox.Size = new System.Drawing.Size(53, 23);
            this.enemyAttackTextBox.TabIndex = 63;
            this.enemyAttackTextBox.TabStop = false;
            this.toolTip1.SetToolTip(this.enemyAttackTextBox, "The enemy will try to do this much damage to you every turn");
            // 
            // PassTurnButton
            // 
            this.PassTurnButton.Location = new System.Drawing.Point(997, 682);
            this.PassTurnButton.Name = "PassTurnButton";
            this.PassTurnButton.Size = new System.Drawing.Size(80, 80);
            this.PassTurnButton.TabIndex = 0;
            this.PassTurnButton.Text = "&End Turn";
            this.toolTip1.SetToolTip(this.PassTurnButton, "Ends your turn and the enemy will try to attack you.");
            this.PassTurnButton.UseVisualStyleBackColor = true;
            this.PassTurnButton.Click += new System.EventHandler(this.PassTurnButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.maxHealthLabel);
            this.groupBox2.Controls.Add(this.currentHealthLabel);
            this.groupBox2.Location = new System.Drawing.Point(496, 659);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(113, 60);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HEALTH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "/";
            // 
            // maxHealthLabel
            // 
            this.maxHealthLabel.AutoSize = true;
            this.maxHealthLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxHealthLabel.Location = new System.Drawing.Point(65, 26);
            this.maxHealthLabel.Name = "maxHealthLabel";
            this.maxHealthLabel.Size = new System.Drawing.Size(42, 31);
            this.maxHealthLabel.TabIndex = 31;
            this.maxHealthLabel.Text = "99";
            // 
            // currentHealthLabel
            // 
            this.currentHealthLabel.AutoSize = true;
            this.currentHealthLabel.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentHealthLabel.Location = new System.Drawing.Point(4, 26);
            this.currentHealthLabel.Name = "currentHealthLabel";
            this.currentHealthLabel.Size = new System.Drawing.Size(42, 31);
            this.currentHealthLabel.TabIndex = 29;
            this.currentHealthLabel.Text = "99";
            // 
            // clickDeckToDrawLabel
            // 
            this.clickDeckToDrawLabel.AutoSize = true;
            this.clickDeckToDrawLabel.Location = new System.Drawing.Point(573, 622);
            this.clickDeckToDrawLabel.Name = "clickDeckToDrawLabel";
            this.clickDeckToDrawLabel.Size = new System.Drawing.Size(236, 17);
            this.clickDeckToDrawLabel.TabIndex = 34;
            this.clickDeckToDrawLabel.Text = "Click the deck below to draw 6 cards!";
            // 
            // enemyNameLabel
            // 
            this.enemyNameLabel.AutoSize = true;
            this.enemyNameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyNameLabel.Location = new System.Drawing.Point(486, 27);
            this.enemyNameLabel.Name = "enemyNameLabel";
            this.enemyNameLabel.Size = new System.Drawing.Size(131, 19);
            this.enemyNameLabel.TabIndex = 42;
            this.enemyNameLabel.Text = "enemyNameLabel";
            // 
            // card1NameLabel
            // 
            this.card1NameLabel.AutoSize = true;
            this.card1NameLabel.Location = new System.Drawing.Point(9, 547);
            this.card1NameLabel.Name = "card1NameLabel";
            this.card1NameLabel.Size = new System.Drawing.Size(110, 17);
            this.card1NameLabel.TabIndex = 43;
            this.card1NameLabel.Text = "card1NameLabel";
            // 
            // card1TypeLabel
            // 
            this.card1TypeLabel.AutoSize = true;
            this.card1TypeLabel.Location = new System.Drawing.Point(9, 564);
            this.card1TypeLabel.Name = "card1TypeLabel";
            this.card1TypeLabel.Size = new System.Drawing.Size(103, 17);
            this.card1TypeLabel.TabIndex = 44;
            this.card1TypeLabel.Text = "card1TypeLabel";
            // 
            // card1ValueLabel
            // 
            this.card1ValueLabel.AutoSize = true;
            this.card1ValueLabel.Location = new System.Drawing.Point(9, 581);
            this.card1ValueLabel.Name = "card1ValueLabel";
            this.card1ValueLabel.Size = new System.Drawing.Size(110, 17);
            this.card1ValueLabel.TabIndex = 45;
            this.card1ValueLabel.Text = "card1ValueLabel";
            // 
            // card2ValueLabel
            // 
            this.card2ValueLabel.AutoSize = true;
            this.card2ValueLabel.Location = new System.Drawing.Point(235, 581);
            this.card2ValueLabel.Name = "card2ValueLabel";
            this.card2ValueLabel.Size = new System.Drawing.Size(110, 17);
            this.card2ValueLabel.TabIndex = 48;
            this.card2ValueLabel.Text = "card2ValueLabel";
            // 
            // card2TypeLabel
            // 
            this.card2TypeLabel.AutoSize = true;
            this.card2TypeLabel.Location = new System.Drawing.Point(235, 564);
            this.card2TypeLabel.Name = "card2TypeLabel";
            this.card2TypeLabel.Size = new System.Drawing.Size(103, 17);
            this.card2TypeLabel.TabIndex = 47;
            this.card2TypeLabel.Text = "card2TypeLabel";
            // 
            // card2NameLabel
            // 
            this.card2NameLabel.AutoSize = true;
            this.card2NameLabel.Location = new System.Drawing.Point(235, 547);
            this.card2NameLabel.Name = "card2NameLabel";
            this.card2NameLabel.Size = new System.Drawing.Size(110, 17);
            this.card2NameLabel.TabIndex = 46;
            this.card2NameLabel.Text = "card2NameLabel";
            // 
            // card3ValueLabel
            // 
            this.card3ValueLabel.AutoSize = true;
            this.card3ValueLabel.Location = new System.Drawing.Point(461, 581);
            this.card3ValueLabel.Name = "card3ValueLabel";
            this.card3ValueLabel.Size = new System.Drawing.Size(110, 17);
            this.card3ValueLabel.TabIndex = 51;
            this.card3ValueLabel.Text = "card3ValueLabel";
            // 
            // card3TypeLabel
            // 
            this.card3TypeLabel.AutoSize = true;
            this.card3TypeLabel.Location = new System.Drawing.Point(461, 564);
            this.card3TypeLabel.Name = "card3TypeLabel";
            this.card3TypeLabel.Size = new System.Drawing.Size(103, 17);
            this.card3TypeLabel.TabIndex = 50;
            this.card3TypeLabel.Text = "card3TypeLabel";
            // 
            // card3NameLabel
            // 
            this.card3NameLabel.AutoSize = true;
            this.card3NameLabel.Location = new System.Drawing.Point(461, 547);
            this.card3NameLabel.Name = "card3NameLabel";
            this.card3NameLabel.Size = new System.Drawing.Size(110, 17);
            this.card3NameLabel.TabIndex = 49;
            this.card3NameLabel.Text = "card3NameLabel";
            // 
            // card4ValueLabel
            // 
            this.card4ValueLabel.AutoSize = true;
            this.card4ValueLabel.Location = new System.Drawing.Point(687, 581);
            this.card4ValueLabel.Name = "card4ValueLabel";
            this.card4ValueLabel.Size = new System.Drawing.Size(110, 17);
            this.card4ValueLabel.TabIndex = 54;
            this.card4ValueLabel.Text = "card4ValueLabel";
            // 
            // card4TypeLabel
            // 
            this.card4TypeLabel.AutoSize = true;
            this.card4TypeLabel.Location = new System.Drawing.Point(687, 564);
            this.card4TypeLabel.Name = "card4TypeLabel";
            this.card4TypeLabel.Size = new System.Drawing.Size(103, 17);
            this.card4TypeLabel.TabIndex = 53;
            this.card4TypeLabel.Text = "card4TypeLabel";
            // 
            // card4NameLabel
            // 
            this.card4NameLabel.AutoSize = true;
            this.card4NameLabel.Location = new System.Drawing.Point(687, 547);
            this.card4NameLabel.Name = "card4NameLabel";
            this.card4NameLabel.Size = new System.Drawing.Size(110, 17);
            this.card4NameLabel.TabIndex = 52;
            this.card4NameLabel.Text = "card4NameLabel";
            // 
            // card5ValueLabel
            // 
            this.card5ValueLabel.AutoSize = true;
            this.card5ValueLabel.Location = new System.Drawing.Point(913, 581);
            this.card5ValueLabel.Name = "card5ValueLabel";
            this.card5ValueLabel.Size = new System.Drawing.Size(110, 17);
            this.card5ValueLabel.TabIndex = 57;
            this.card5ValueLabel.Text = "card5ValueLabel";
            // 
            // card5TypeLabel
            // 
            this.card5TypeLabel.AutoSize = true;
            this.card5TypeLabel.Location = new System.Drawing.Point(913, 564);
            this.card5TypeLabel.Name = "card5TypeLabel";
            this.card5TypeLabel.Size = new System.Drawing.Size(103, 17);
            this.card5TypeLabel.TabIndex = 56;
            this.card5TypeLabel.Text = "card5TypeLabel";
            // 
            // card5NameLabel
            // 
            this.card5NameLabel.AutoSize = true;
            this.card5NameLabel.Location = new System.Drawing.Point(913, 547);
            this.card5NameLabel.Name = "card5NameLabel";
            this.card5NameLabel.Size = new System.Drawing.Size(110, 17);
            this.card5NameLabel.TabIndex = 55;
            this.card5NameLabel.Text = "card5NameLabel";
            // 
            // card6ValueLabel
            // 
            this.card6ValueLabel.AutoSize = true;
            this.card6ValueLabel.Location = new System.Drawing.Point(1139, 581);
            this.card6ValueLabel.Name = "card6ValueLabel";
            this.card6ValueLabel.Size = new System.Drawing.Size(110, 17);
            this.card6ValueLabel.TabIndex = 60;
            this.card6ValueLabel.Text = "card6ValueLabel";
            // 
            // card6TypeLabel
            // 
            this.card6TypeLabel.AutoSize = true;
            this.card6TypeLabel.Location = new System.Drawing.Point(1139, 564);
            this.card6TypeLabel.Name = "card6TypeLabel";
            this.card6TypeLabel.Size = new System.Drawing.Size(103, 17);
            this.card6TypeLabel.TabIndex = 59;
            this.card6TypeLabel.Text = "card6TypeLabel";
            // 
            // card6NameLabel
            // 
            this.card6NameLabel.AutoSize = true;
            this.card6NameLabel.Location = new System.Drawing.Point(1139, 547);
            this.card6NameLabel.Name = "card6NameLabel";
            this.card6NameLabel.Size = new System.Drawing.Size(110, 17);
            this.card6NameLabel.TabIndex = 58;
            this.card6NameLabel.Text = "card6NameLabel";
            // 
            // playerCardImages
            // 
            this.playerCardImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("playerCardImages.ImageStream")));
            this.playerCardImages.TransparentColor = System.Drawing.Color.Transparent;
            this.playerCardImages.Images.SetKeyName(0, "1-3.png");
            this.playerCardImages.Images.SetKeyName(1, "PunchCard.png");
            this.playerCardImages.Images.SetKeyName(2, "NunchuckCard.png");
            this.playerCardImages.Images.SetKeyName(3, "EnergyCard.png");
            this.playerCardImages.Images.SetKeyName(4, "IceCard.png");
            this.playerCardImages.Images.SetKeyName(5, "FireCard.png");
            this.playerCardImages.Images.SetKeyName(6, "NukeCard.png");
            this.playerCardImages.Images.SetKeyName(7, "StaffCard.png");
            this.playerCardImages.Images.SetKeyName(8, "SilverAxeCard.png");
            this.playerCardImages.Images.SetKeyName(9, "ShieldCard.png");
            this.playerCardImages.Images.SetKeyName(10, "GreatAxeCard.png");
            this.playerCardImages.Images.SetKeyName(11, "SilverSwordCard.png");
            this.playerCardImages.Images.SetKeyName(12, "LightningCard.png");
            this.playerCardImages.Images.SetKeyName(13, "CureCard.png");
            this.playerCardImages.Images.SetKeyName(14, "RedShieldCard.png");
            this.playerCardImages.Images.SetKeyName(15, "DoubleCastCard.png");
            this.playerCardImages.Images.SetKeyName(16, "DaggerCard.png");
            this.playerCardImages.Images.SetKeyName(17, "WeakenCard.png");
            this.playerCardImages.Images.SetKeyName(18, "KatanaCard.png");
            this.playerCardImages.Images.SetKeyName(19, "HammerCard.png");
            this.playerCardImages.Images.SetKeyName(20, "HealCard.png");
            this.playerCardImages.Images.SetKeyName(21, "ProtectCard.png");
            this.playerCardImages.Images.SetKeyName(22, "HealingPotionCard.png");
            this.playerCardImages.Images.SetKeyName(23, "MixtureCard.png");
            this.playerCardImages.Images.SetKeyName(24, "ConcoctionCard.png");
            // 
            // enemyImages
            // 
            this.enemyImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("enemyImages.ImageStream")));
            this.enemyImages.TransparentColor = System.Drawing.Color.Transparent;
            this.enemyImages.Images.SetKeyName(0, "GoblinCard.png");
            this.enemyImages.Images.SetKeyName(1, "WolvesCard.png");
            this.enemyImages.Images.SetKeyName(2, "ZombiesCard.png");
            this.enemyImages.Images.SetKeyName(3, "PirateCard.png");
            this.enemyImages.Images.SetKeyName(4, "SahaginCard.png");
            this.enemyImages.Images.SetKeyName(5, "OgreCard.png");
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Location = new System.Drawing.Point(12, 685);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(81, 17);
            this.blockLabel.TabIndex = 61;
            this.blockLabel.Text = "Block Label";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "Damage:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitGameToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // quitGameToolStripMenuItem
            // 
            this.quitGameToolStripMenuItem.Name = "quitGameToolStripMenuItem";
            this.quitGameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.quitGameToolStripMenuItem.Text = "&Quit Game";
            this.quitGameToolStripMenuItem.Click += new System.EventHandler(this.quitGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // damageUpLabel
            // 
            this.damageUpLabel.AutoSize = true;
            this.damageUpLabel.Location = new System.Drawing.Point(12, 702);
            this.damageUpLabel.Name = "damageUpLabel";
            this.damageUpLabel.Size = new System.Drawing.Size(105, 17);
            this.damageUpLabel.TabIndex = 65;
            this.damageUpLabel.Text = "damageUpLabel";
            // 
            // mixtureCounterLabel
            // 
            this.mixtureCounterLabel.AutoSize = true;
            this.mixtureCounterLabel.Location = new System.Drawing.Point(12, 719);
            this.mixtureCounterLabel.Name = "mixtureCounterLabel";
            this.mixtureCounterLabel.Size = new System.Drawing.Size(142, 17);
            this.mixtureCounterLabel.TabIndex = 66;
            this.mixtureCounterLabel.Text = "mixtureCounterLabel";
            // 
            // Game
            // 
            this.AcceptButton = this.PassTurnButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 832);
            this.Controls.Add(this.mixtureCounterLabel);
            this.Controls.Add(this.damageUpLabel);
            this.Controls.Add(this.enemyAttackTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.blockLabel);
            this.Controls.Add(this.card6ValueLabel);
            this.Controls.Add(this.card6TypeLabel);
            this.Controls.Add(this.card6NameLabel);
            this.Controls.Add(this.card5ValueLabel);
            this.Controls.Add(this.card5TypeLabel);
            this.Controls.Add(this.card5NameLabel);
            this.Controls.Add(this.card4ValueLabel);
            this.Controls.Add(this.card4TypeLabel);
            this.Controls.Add(this.card4NameLabel);
            this.Controls.Add(this.card3ValueLabel);
            this.Controls.Add(this.card3TypeLabel);
            this.Controls.Add(this.card3NameLabel);
            this.Controls.Add(this.card2ValueLabel);
            this.Controls.Add(this.card2TypeLabel);
            this.Controls.Add(this.card2NameLabel);
            this.Controls.Add(this.card1ValueLabel);
            this.Controls.Add(this.card1TypeLabel);
            this.Controls.Add(this.card1NameLabel);
            this.Controls.Add(this.enemyNameLabel);
            this.Controls.Add(this.clickDeckToDrawLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PassTurnButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enemyCurrentHealth);
            this.Controls.Add(this.Card5);
            this.Controls.Add(this.DeckBack);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card6);
            this.Controls.Add(this.Card1);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.enemyPic);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Andrew Russo Final Project TBD";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.enemyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeckBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Card5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox enemyPic;
        private System.Windows.Forms.PictureBox Card2;
        private System.Windows.Forms.PictureBox Card3;
        private System.Windows.Forms.PictureBox Card1;
        private System.Windows.Forms.PictureBox DeckBack;
        private System.Windows.Forms.PictureBox Card4;
        private System.Windows.Forms.PictureBox Card6;
        private System.Windows.Forms.PictureBox Card5;
        private System.Windows.Forms.TextBox enemyCurrentHealth;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PassTurnButton;
        private System.Windows.Forms.Label currentEnergyLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label maxEnergyLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxHealthLabel;
        private System.Windows.Forms.Label currentHealthLabel;
        private System.Windows.Forms.Label clickDeckToDrawLabel;
        private System.Windows.Forms.Label enemyNameLabel;
        private System.Windows.Forms.Label card1NameLabel;
        private System.Windows.Forms.Label card1TypeLabel;
        private System.Windows.Forms.Label card1ValueLabel;
        private System.Windows.Forms.Label card2ValueLabel;
        private System.Windows.Forms.Label card2TypeLabel;
        private System.Windows.Forms.Label card2NameLabel;
        private System.Windows.Forms.Label card3ValueLabel;
        private System.Windows.Forms.Label card3TypeLabel;
        private System.Windows.Forms.Label card3NameLabel;
        private System.Windows.Forms.Label card4ValueLabel;
        private System.Windows.Forms.Label card4TypeLabel;
        private System.Windows.Forms.Label card4NameLabel;
        private System.Windows.Forms.Label card5ValueLabel;
        private System.Windows.Forms.Label card5TypeLabel;
        private System.Windows.Forms.Label card5NameLabel;
        private System.Windows.Forms.Label card6ValueLabel;
        private System.Windows.Forms.Label card6TypeLabel;
        private System.Windows.Forms.Label card6NameLabel;
        private System.Windows.Forms.ImageList playerCardImages;
        private System.Windows.Forms.ImageList enemyImages;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enemyAttackTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitGameToolStripMenuItem;
        private System.Windows.Forms.Label damageUpLabel;
        private System.Windows.Forms.Label mixtureCounterLabel;
    }
}

