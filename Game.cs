// Andrew Russo
// CPT-185-A80S
// Final Project

// Link to wlive file I'm sharing with friends/family https://drive.google.com/drive/folders/1SWxz8fNImXiRCR7WshLuedjHrry4Hw8c?usp=sharing
// I needed feedback and bug testers and some people liked it enough that I might continue to add to the game later.
// this includes notes from them, and me, recent updates and where I'm/we're hoping to see things progress

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AndrewRusso_CPT_185_Final_Project
{
    public partial class Game : Form
    {
        // Public Variables here
        // Create an instance of the DeckSelection form, should get the "deck" element
        public DeckSelection pickDeck = new DeckSelection();

        public Shop rescue = new Shop();

        // List for enemies that we'll call another class to populate
        public List<Enemy> badGuyList = new List<Enemy>();

        // Random index for enemy selection
        public int badIndex;

        // enemy and player stats
        public int enemyAttack = 0;
        public int enemyHealth = 1;
        public int enemyHitChance = 0;
        public int enemyDamageDealt = 0;

        public const double playerDefaultDamageMultiplier = 1.0; //default value (lets us avoid checking for it in every calculation
        public double playerDamageMultiplier = playerDefaultDamageMultiplier; // this one will change between the dfault value and the increase value 
        public double playerDamageMultiplierIncrease = 2.5; // using a static damage multiplier value
        public int buffCounter = 0;

        public const int playerDefaultHealth = 20; // Added a default value
        public int playerMaxHealth = playerDefaultHealth;
        public int playerCurrentHealth = playerDefaultHealth;

        public const int playerDefaultEnergy = 3; // I want to make a default value
        public int playerCurrentEnergy = playerDefaultEnergy;
        public int playerMaxEnergy = playerDefaultEnergy;

        public int playerBlock = 0;

        /* Made the default values so they can adjusted in one spot. This causes the max values and the starting values to adjust on game lunch and there's no need to hunt to find every time energy is reset.
         * 
         */

        // Counters
        public int defeated = 0; // Enemies defeated counter
        public int turn = 1; // Count turns for boss, scripted events, "store/rescue" options
        public double mixture = 0; // Counter for mixture/concoction damage

        // on/off switches
        public bool playerTurn = false;
        public bool playerCanDraw = false;
        public bool playerCanPlayCards = false;
        public static bool playerCanMix = false; // Trigger for deny/allowing mixture/concoction counter. Activated by the ApothecaryDeck() method in Shop
        // public static bool playerBOOL_VALUE = false; // should match what was added for a job in the Shop, if a trigger is needed to activate an addition element/text

        // card switches
        public bool card1Playable = false;
        public bool card2Playable = false;
        public bool card3Playable = false;
        public bool card4Playable = false;
        public bool card5Playable = false;
        public bool card6Playable = false;

        // Public Index values to tie to the deck(list), index goes from 0 to 23, maybe in an array?
        public int[] cardIndex = new int[6];

        public Game()
        {
            InitializeComponent();
        }
        public void MakeEnemies(List<Enemy> badGuyList) // I would move this to a seperate class and lay it out like the decks in DeckSelection
                                                        // I left it here since it is a small condensed method like this
                                                        // But moving it would make it easier to expand and make things read better.
        {
            string[] name = { "Goblin", "Wolves", "Zombies", "Pirate", "Sahagin", "Ogre" };
            int[] health = { 20, 30, 50, 30, 40, 60 };
            int[] attack = { 3, 2, 3, 2, 3, 8 };
            int[] hit = { 3, 2, 3, 2, 2, 4 }; // chance is 1 in X (where x is the number here)(ie. 1 is 1:1, 2 is 1:2, and so on)
            int[] image = { 0, 1, 2, 3, 4, 5 };

            for (int i = 0; i < name.Length; i++)
            {
                Enemy enemyInfo = new Enemy(); // reinitialize for each run through
                enemyInfo.EnemyName = name[i]; // get enemy name
                enemyInfo.EnemyHealth = health[i]; // get enemy health
                enemyInfo.EnemyAttack = attack[i]; // get enemy attack
                enemyInfo.EnemyChanceToAttack = hit[i]; // get enemy change to hit
                enemyInfo.EnemyImageIndex = image[i]; // get the index for the enemy's image
                
                // Add enemyInfo to the badGuyList
                badGuyList.Add(enemyInfo);
            }
        } // end MakeEnemies()

        public void EnemyAttack()
        {
            Random hit = new Random();

            // Get a random number between 0 and < the ChanceToAttack value. (If chance is 4, random number will be either 0, 1, 2, or 3. a 1 in 4 chance to hit)
            int hitOrMiss = hit.Next(badGuyList[badIndex].EnemyChanceToAttack);

            if (hitOrMiss == 0)// always hit on 0, this allows ChanceToAttack to go as low as 1 and be 100% hit rate.
            { 
                if (badGuyList[badIndex].EnemyAttack > playerBlock) // make sure damage is higher than block value
                {
                    int enemyDamageDealt = badGuyList[badIndex].EnemyAttack - playerBlock; // if it is higher do the math and deal the damage
                    MessageBox.Show("The " + badGuyList[badIndex].EnemyName + " hit you dealing " + enemyDamageDealt.ToString() + " damage!");
                    playerCurrentHealth -= enemyDamageDealt;
                }
                else
                {
                    MessageBox.Show("You managed to block all incoming damage!");
                }

                currentHealthLabel.Text = playerCurrentHealth.ToString();
                ClearBlock(); // clear block after succesful enemy attack
            }
            else
            {
                MessageBox.Show("The " + badGuyList[badIndex].EnemyName + " missed you!");
            }
            
            if (playerCurrentHealth <= 0) // Check to see if player has lost. This might need to change is we add enemies with DOTs or abilities that self harm
            {
                GameOver();
            }
          }

        public void SelectEnemy()
        {
            // Thinking to move this to structured

            Random index = new Random();
            badIndex = index.Next(badGuyList.Count); // using count here allows enemies to be added an no other code needs to be altered

            // Display the enemy's info
            enemyNameLabel.Text = badGuyList[badIndex].EnemyName; // display enemy name
            enemyCurrentHealth.Text = badGuyList[badIndex].EnemyHealth.ToString("n0"); // display enemy HP without decimals
            enemyAttackTextBox.Text = badGuyList[badIndex].EnemyAttack.ToString(); // display enemy attack value
            enemyHealth = badGuyList[badIndex].EnemyHealth; // send enemy HP to the enemyHealth variable since we need this to count down
            enemyPic.Image = enemyImages.Images[badGuyList[badIndex].EnemyImageIndex];
        } // end SelectEnemy()

        public void DrawCards()
        {
            // Create 6 random numbers
            Random pick = new Random();

            for (int i = 0; i < 6; i++) // iterate the card drawing process
            {
                int newPick;
                do
                {
                    newPick = pick.Next(DeckSelection.playerDeck.Count);
                } while (cardIndex.Contains(newPick)); //generates a new number until we get one not already in the array.

                cardIndex[i] = newPick; // adds the random int to the array
            }

            playerCanDraw = false; // stop player from drawing again
            playerCanPlayCards = true; // allow player to play their cards
            
            // Make the cards playable again
            card1Playable = true;
            card2Playable = true;
            card3Playable = true;
            card4Playable = true;
            card5Playable = true;
            card6Playable = true;

        } // end DrawCards()

        public void MakePlayerTurn()
        {
            ClearCards();
            playerCurrentEnergy = playerDefaultEnergy;
            playerTurn = true;
            playerCanDraw = true;
            playerCanPlayCards = false;
            currentEnergyLabel.Text = playerCurrentEnergy.ToString();
            clickDeckToDrawLabel.Text = "Click the deck below to draw 6 cards!";
        }

        private void ResetPlayerHealth()
        {
            playerCurrentHealth = playerDefaultHealth;
            currentHealthLabel.Text = playerCurrentHealth.ToString();
        }

        public void PassTurnButton_Click(object sender, EventArgs e) // I wanted to rename this but i'm not risking everything I have for that.
        {
            // Allows player to pass their turn
            var message = "Would you like to finish your turn?";
            var title = "Finished?";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    EnemyAttack();
                    CheckCrit();
                    MakePlayerTurn();
                    break;

                case DialogResult.No:
                    break;

                default:
                    MessageBox.Show("Nothing was pressed?!?!");
                    break;
            }

        } //end PassTurnButton

        private void Form1_Load(object sender, EventArgs e)
        {
            pickDeck.ShowDialog(); // Open the card selection form and let player pick cards to add.
            ClearBlock();
            CheckCrit();
            ClearMixture();
            MakeEnemies(badGuyList); // Make the enemies by forming the Enemy list
            SelectEnemy(); // Pick an enemy to battle
            MakePlayerTurn();

            // Update our values
            currentHealthLabel.Text = playerCurrentHealth.ToString();
            maxHealthLabel.Text = playerMaxHealth.ToString();
            maxEnergyLabel.Text = playerMaxEnergy.ToString();

        } // end Form1_Load

        public void GameOver()
        {
            var message = "You have been defeated! Would you like to try again?";
            var title = "Defeat!";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    DeckSelection.playerDeck.Clear();
                    pickDeck.ShowDialog(); // Open the card selection form and let player pick cards to add.
                    ClearCards();
                    ClearBlock();
                    CheckCrit();
                    ResetPlayerHealth();
                    MakeEnemies(badGuyList); // Make the enemies by forming the Enemy list
                    SelectEnemy(); // Pick an enemy to battle
                    MakePlayerTurn();
                    break;

                case DialogResult.No:
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Nothing was pressed?!?!");
                    break;
            }
        }

        public void DeckBack_Click(object sender, EventArgs e)
        {
            // Make sure it is the player's turn
            if (playerTurn && playerCanDraw)
            {
                DrawCards();
                clickDeckToDrawLabel.Text = ""; // clear the label instructing player to click deck after they draw cards.
                DisplayCards(); // Display the Cards selected
            }
            
        }

        private void DisplayCards()
        {
            
            card1NameLabel.Text = DeckSelection.playerDeck[cardIndex[0]].CardName;
            card1TypeLabel.Text = DetermineType(DeckSelection.playerDeck[cardIndex[0]].CardType);
            card1ValueLabel.Text = DeckSelection.playerDeck[cardIndex[0]].CardValue.ToString();
            Card1.Image = playerCardImages.Images[DeckSelection.playerDeck[cardIndex[0]].CardImage];

            card2NameLabel.Text = DeckSelection.playerDeck[cardIndex[1]].CardName;
            card2TypeLabel.Text = DetermineType(DeckSelection.playerDeck[cardIndex[1]].CardType);
            card2ValueLabel.Text = DeckSelection.playerDeck[cardIndex[1]].CardValue.ToString();
            Card2.Image = playerCardImages.Images[DeckSelection.playerDeck[cardIndex[1]].CardImage];

            card3NameLabel.Text = DeckSelection.playerDeck[cardIndex[2]].CardName;
            card3TypeLabel.Text = DetermineType(DeckSelection.playerDeck[cardIndex[2]].CardType);
            card3ValueLabel.Text = DeckSelection.playerDeck[cardIndex[2]].CardValue.ToString();
            Card3.Image = playerCardImages.Images[DeckSelection.playerDeck[cardIndex[2]].CardImage];

            card4NameLabel.Text = DeckSelection.playerDeck[cardIndex[3]].CardName;
            card4TypeLabel.Text = DetermineType(DeckSelection.playerDeck[cardIndex[3]].CardType);
            card4ValueLabel.Text = DeckSelection.playerDeck[cardIndex[3]].CardValue.ToString();
            Card4.Image = playerCardImages.Images[DeckSelection.playerDeck[cardIndex[3]].CardImage];

            card5NameLabel.Text = DeckSelection.playerDeck[cardIndex[4]].CardName;
            card5TypeLabel.Text = DetermineType(DeckSelection.playerDeck[cardIndex[4]].CardType);
            card5ValueLabel.Text = DeckSelection.playerDeck[cardIndex[4]].CardValue.ToString();
            Card5.Image = playerCardImages.Images[DeckSelection.playerDeck[cardIndex[4]].CardImage];

            card6NameLabel.Text = DeckSelection.playerDeck[cardIndex[5]].CardName;
            card6TypeLabel.Text = DetermineType(DeckSelection.playerDeck[cardIndex[5]].CardType);
            card6ValueLabel.Text = DeckSelection.playerDeck[cardIndex[5]].CardValue.ToString();
            Card6.Image = playerCardImages.Images[DeckSelection.playerDeck[cardIndex[5]].CardImage];
        } // end DisplayCard()

        public string DetermineType(int type)
        {

            /* Key for CardType
             * 1 - Attack
             * 2 - Heal (retore health)
             * 3 - Shield (absorbs damage)
             * 4 - Damage up (increase dmg player by the set multiplier for (value) turns)
             * 5 - Energy up (adds player energy)
             * 6 - Mixture (add to mix counter to increase damage done by concoction)
             * 7 - Use Concoction (uses stored up mixture)
             */

            switch (type)
            {
                case 1:
                    return "Attack";
                case 2:
                    return "Heal";
                case 3:
                    return "Block";
                case 4:
                    return "Increase Damage";
                case 5:
                    return "Increase Energy";
                case 6:
                    return "Add to mixture";
                case 7:
                    return "Throw concoction";
                default:
                    MessageBox.Show("Determining Type failed!");
                    return "Error determining type";
                    
            }
        } // end DetermineType()

        private void Card1_Click(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                MessageBox.Show("It is not your turn. Please wait for the draw from deck message to appear.");
            }
            else if (!card1Playable) { }
            else if (!playerCanPlayCards)
            {
                MessageBox.Show("You must first draw cards from the deck.");
            }
            else if (playerCurrentEnergy <= 0)
            {
                MessageBox.Show("You do not have enough energy remaining to play this card. Please end turn.");
            }
            else
            {
                DoCard(cardIndex[0]);

                // update card detals to be vacant and not allow card to be used again
                card1Playable = false;
                card1NameLabel.Text = "";
                card1TypeLabel.Text = "";
                card1ValueLabel.Text = "";
                Card1.Image = playerCardImages.Images[0];
            }
            
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                MessageBox.Show("It is not your turn. Please wait for the draw from deck message to appear.");
            }
            else if (!card2Playable) { }
            else if (!playerCanPlayCards)
            {
                MessageBox.Show("You must first draw cards from the deck.");
            }
            else if (playerCurrentEnergy <= 0)
            {
                MessageBox.Show("You do not have enough energy remaining to play this card. Please end turn.");
            }
            else
            {
                DoCard(cardIndex[1]);

                // update card detals to be vacant and not allow card to be used again
                card2Playable = false;
                card2NameLabel.Text = "";
                card2TypeLabel.Text = "";
                card2ValueLabel.Text = "";
                Card2.Image = playerCardImages.Images[0];
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                MessageBox.Show("It is not your turn. Please wait for the draw from deck message to appear.");
            }
            else if (!card3Playable) { }
            else if (!playerCanPlayCards)
            {
                MessageBox.Show("You must first draw cards from the deck.");
            }
            else if (playerCurrentEnergy <= 0)
            {
                MessageBox.Show("You do not have enough energy remaining to play this card. Please end turn.");
            }
            else
            {
                DoCard(cardIndex[2]);

                // update card detals to be vacant and not allow card to be used again
                card3Playable = false;
                card3NameLabel.Text = "";
                card3TypeLabel.Text = "";
                card3ValueLabel.Text = "";
                Card3.Image = playerCardImages.Images[0];
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                MessageBox.Show("It is not your turn. Please wait for the draw from deck message to appear.");
            }
            else if (!card4Playable) { }
            else if (!playerCanPlayCards)
            {
                MessageBox.Show("You must first draw cards from the deck.");
            }
            else if (playerCurrentEnergy <= 0)
            {
                MessageBox.Show("You do not have enough energy remaining to play this card. Please end turn.");
            }
            else
            {
                DoCard(cardIndex[3]);

                // update card detals to be vacant and not allow card to be used again
                card4Playable = false;
                card4NameLabel.Text = "";
                card4TypeLabel.Text = "";
                card4ValueLabel.Text = "";
                Card4.Image = playerCardImages.Images[0];
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                MessageBox.Show("It is not your turn. Please wait for the draw from deck message to appear.");
            }
            else if (!card5Playable) { }
            else if (!playerCanPlayCards)
            {
                MessageBox.Show("You must first draw cards from the deck.");
            }
            else if (playerCurrentEnergy <= 0)
            {
                MessageBox.Show("You do not have enough energy remaining to play this card. Please end turn.");
            }
            else
            {
                DoCard(cardIndex[4]);

                // update card detals to be vacant and not allow card to be used again
                card5Playable = false;
                card5NameLabel.Text = "";
                card5TypeLabel.Text = "";
                card5ValueLabel.Text = "";
                Card5.Image = playerCardImages.Images[0];
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            if (!playerTurn)
            {
                MessageBox.Show("It is not your turn. Please wait for the draw from deck message to appear.");
            }
            else if (!card6Playable) { }
            else if (!playerCanPlayCards)
            {
                MessageBox.Show("You must first draw cards from the deck.");
            }
            else if (playerCurrentEnergy <= 0)
            {
                MessageBox.Show("You do not have enough energy remaining to play this card. Please end turn.");
            }
            else
            {
                DoCard(cardIndex[5]);

                // update card detals to be vacant and not allow card to be used again
                card6Playable = false;
                card6NameLabel.Text = "";
                card6TypeLabel.Text = "";
                card6ValueLabel.Text = "";
                Card6.Image = playerCardImages.Images[0];
            }
        }

        private void DoCard(int index)
        {
            playerCurrentEnergy -= 1;
            currentEnergyLabel.Text = playerCurrentEnergy.ToString();

            int type = DeckSelection.playerDeck[index].CardType;

            switch (type)
            {
                case 1: // Attack
                    Attack(DeckSelection.playerDeck[index].CardValue);
                    break;
                case 2: // Heal
                    Heal(DeckSelection.playerDeck[index].CardValue);
                    break;
                case 3: // Block
                    Shield(DeckSelection.playerDeck[index].CardValue);
                    break;
                case 4: // Increase Damage
                    DamageUp(DeckSelection.playerDeck[index].CardValue);
                    break;
                case 5: // Increase Energy
                    IncreaseEnergy(DeckSelection.playerDeck[index].CardValue);
                    break;
                case 6:
                    Mixture(DeckSelection.playerDeck[index].CardValue);
                    break;
                case 7:
                    Concoction();
                    break;
                default:
                    MessageBox.Show("Determining Type during DoCard failed!");
                    break;
            }
        } // end DoCard()
        
        public void ClearCards()
        {
            card1NameLabel.Text = "";
            card1TypeLabel.Text = "";
            card1ValueLabel.Text = "";
            Card1.Image = playerCardImages.Images[0];

            card2NameLabel.Text = "";
            card2TypeLabel.Text = "";
            card2ValueLabel.Text = "";
            Card2.Image = playerCardImages.Images[0];

            card3NameLabel.Text = "";
            card3TypeLabel.Text = "";
            card3ValueLabel.Text = "";
            Card3.Image = playerCardImages.Images[0];

            card4NameLabel.Text = "";
            card4TypeLabel.Text = "";
            card4ValueLabel.Text = "";
            Card4.Image = playerCardImages.Images[0];

            card5NameLabel.Text = "";
            card5TypeLabel.Text = "";
            card5ValueLabel.Text = "";
            Card5.Image = playerCardImages.Images[0];

            card6NameLabel.Text = "";
            card6TypeLabel.Text = "";
            card6ValueLabel.Text = "";
            Card6.Image = playerCardImages.Images[0];

            // int[] cardIndex = new int[6]; //clear out the index by reinitializing
        }

        public void ClearBlock()
        {
            playerBlock = 0;
            blockLabel.Text = "";
        }

        public void ClearCrit()
        {
            buffCounter = 0;
            damageUpLabel.Text = "";
        }

        public void ClearMixture()
        {
            if (playerCanMix)
            {
                mixture = 0;
                mixtureCounterLabel.Text = "Mixture damage: " + mixture.ToString("n0");
            }
            else
            {
                mixture = 0;
                mixtureCounterLabel.Text = "";
            }
        }

        private void CheckCrit()
        {
            // check for a buffCounter value above 0 to count down
            if (buffCounter > 2) // we want to make sure this is 0 or above to avoid negative time values
            {
                buffCounter -= 1; //tick off a turn of buff if we have it
                damageUpLabel.Text = "You deal 2.5 times damage for " + buffCounter.ToString() + " more turns!";
            }
            else if (buffCounter == 2) // we want to make sure this is 0 or above to avoid negative time values
            {
                buffCounter -= 1; //tick off a turn of the buff
                damageUpLabel.Text = "You deal 2.5 times damage for " + buffCounter.ToString() + " more turn!";
            }

            else if (buffCounter == 1)
            {
                buffCounter -= 1; //remove the final turn
                damageUpLabel.Text = "";
                playerDamageMultiplier = playerDefaultDamageMultiplier;
            }
            else
            {
                damageUpLabel.Text = "";
            }
        }

        public void VictoryScreen()
        {
            defeated++; // increase emey kill counter

            if (defeated == 1)
            {
                rescue.ShowDialog(); // open the shop/rescue window
            }

            var message = "You defeated the enemy!\nYou have deafeated " + defeated.ToString() + " enemies so far.\nWould you like to fight another?";
            var title = "Victory";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            switch (result)
            {
                case DialogResult.Yes:
                    SelectEnemy();
                    MakePlayerTurn();
                    ClearBlock();
                    ClearCrit();
                    ClearMixture();
                    break;

                case DialogResult.No:
                    MessageBox.Show("Thank you for playing!");
                    this.Close();
                    break;

                default:
                    MessageBox.Show("Nothing was pressed?!?!");
                    break;
            }
        }

        // PLAYER ACTIONS

        private void Attack(double damage)
        {
            damage *= playerDamageMultiplier;
            enemyHealth -= Convert.ToInt32(damage);
            enemyCurrentHealth.Text = enemyHealth.ToString();

            if (enemyHealth <= 0)
            {
                VictoryScreen();
            }
        }

        private void Heal(double heal)
        {
            playerCurrentHealth += Convert.ToInt32(heal);
            
            if (playerCurrentHealth > playerMaxHealth)
            {
                playerCurrentHealth = playerMaxHealth;
            }

            currentHealthLabel.Text = playerCurrentHealth.ToString();
        }

        private void Shield(double shield)
        {
            playerBlock += Convert.ToInt32(shield);
            blockLabel.Text = "BLOCKING! You will reduce damage from the next attack by " + playerBlock.ToString() + "!";
        }

        private void DamageUp(double buffDuration)
        {
            playerDamageMultiplier = playerDamageMultiplierIncrease;
            buffCounter += Convert.ToInt32(buffDuration); // number of turns the damage buff should last (counts down after enemy turn)
            damageUpLabel.Text = "You will now deal 2.5 times damage for " + buffCounter.ToString() + " turns!"; // update game text
        }

        private void IncreaseEnergy(double upEnergy)
        {
            playerCurrentEnergy += Convert.ToInt32(upEnergy);
            currentEnergyLabel.Text = playerCurrentEnergy.ToString();
        }

        private void Mixture(double mix) // mixture adds to a counter that then gets used by a Throw concoction
        {
            mixture += mix;
            mixtureCounterLabel.Text = "Mixture damage: " + mixture.ToString("n0");
        }
        
        private void Concoction()
        {
            double dmgToEnemy = mixture * playerDamageMultiplier;
            enemyHealth -= Convert.ToInt32(dmgToEnemy);
            enemyCurrentHealth.Text = enemyHealth.ToString();
            mixture = 0;
            mixtureCounterLabel.Text = "Mixture damage: " + mixture.ToString("n0");

            if (enemyHealth <= 0)
            {
                VictoryScreen();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create help window instance
            Help helpForm = new Help();
            helpForm.ShowDialog();
        }

        private void quitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the program
            var message = "Would you like to quit the game?";
            var title = "Exit?";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Thank you for playing!");
                    this.Close();
                    break;

                case DialogResult.No:
                    MessageBox.Show("Play on!");
                    break;

                default:
                    MessageBox.Show("Nothing was pressed?!?!");
                    break;
            }
        }
    }
}
