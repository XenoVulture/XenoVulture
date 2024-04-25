using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndrewRusso_CPT_185_Final_Project
{
    public partial class Shop : Form
    {
        // Public variables go here
        public string jobName = "";

        public int jobIndex;

        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            RandomRescue();
        }

        private void RandomRescue()
        {
            Random draft = new Random();
            jobIndex = draft.Next(shopJobImageList.Images.Count);
            foundJobPictureBox.Image = shopJobImageList.Images[jobIndex];
            JobText(jobIndex);
        }

        private void JobText(int jobNum)
        {
            switch (jobNum)
            {
                case 0:
                    jobInfoTextBox.Text = "Apothecary\r\n\r\nCan do minor amounts of healing.\r\nUse Mixture cards to stockpile damage and then dish it out by using the Concoction card.";
                    jobFoundLabel.Text = "You have found the Apothecary!";
                    jobName = "Apothecary";
                    break;
                default:
                    MessageBox.Show("Generating Job Text has failed!");
                    break;
            }
        }

        private void addCardsButton_Click(object sender, EventArgs e)
        {
            WhichJob(jobName);
            this.Close();
        }

        private void doNotAddCardsButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WhichJob(string choice)
        {
            switch (choice)
            {
                case "Apothecary":
                    apothecaryDeck();
                    break;
                default:
                    MessageBox.Show("Error with WhichJob method!");
                    break;
            }
        }

        /* Key for CardType
         * 1 - Attack
         * 2 - Heal (retore health)
         * 3 - Shield (absorbs damage)
         * 4 - Damage up (increase dmg player by the set multiplier for (value) turns)
         * 5 - Energy up (adds player energy)
         * 6 - Mixture (add to mix counter to increase damage done by concoction)
         * 7 - Use Concoction (uses stored up mixture)
         */

        /* Blank for adding more decks in the future
         * 
        private void JOBNAMEDeck()
        {
            // Card stat arrays for 
            string[] name = { "", "", "", "", "", "" };
            int[] type = { , , , , ,  };
            double[] value = { , , , , ,  };
            int[] image = { , , , , ,  };

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                DeckSelection.playerCard = new Card(); // Figured out I need to reinitialize this or if fouls up
                DeckSelection.playerCard.CardName = name[i]; // get card name
                DeckSelection.playerCard.CardType = type[i]; // get the card type
                DeckSelection.playerCard.CardValue = value[i]; // get the card's value
                DeckSelection.playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                DeckSelection.playerDeck.Add(DeckSelection.playerCard);
            }
            Game.BOOL_VALUE = true;  // If a special feature needs to be triggered on, be sure to add it here AND add it to the Game code
        }
        */

        public void apothecaryDeck() // JOB INDEX 0
        {
            // need to look into adding button or a counter for mixes and another "type"
            // Card stat arrays for Apothecary
            string[] name = { "Healing Potion", "Healing Potion", "Mixture", "Mixture", "Mixture", "Concoction" };
            int[] type = { 2, 2, 6, 6, 6, 7 };
            double[] value = { 2, 2, 2.4, 2.4, 2.4, 0 };
            int[] image = { 22, 22, 23, 23, 23, 24 };

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                DeckSelection.playerCard = new Card(); // Figured out I need to reinitialize this or if fouls up
                DeckSelection.playerCard.CardName = name[i]; // get card name
                DeckSelection.playerCard.CardType = type[i]; // get the card type
                DeckSelection.playerCard.CardValue = value[i]; // get the card's value
                DeckSelection.playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                DeckSelection.playerDeck.Add(DeckSelection.playerCard);
            }
            Game.playerCanMix = true; // this value was added to Game, and needs to be here to turn on the option to display mixture damage
        }
    }
}
