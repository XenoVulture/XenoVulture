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

    public partial class DeckSelection : Form
    {
        // Public variables go here
        public int choicesRemaining = 4; // used to count down selections

        // Create the List
        public static List<Card> playerDeck = new List<Card>();

        // Create the Card object
        public static Card playerCard = new Card();

        public DeckSelection()
        {
            InitializeComponent();
        }

        private void SelectionDialog(string job)
        {
            // Message box to confirm job selection before adding to the deck

            var message = ("Would you like to add the " + job + " to your deck?");
            var title = "Bring the " + job + "?";
            var result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    WhichDeck(job);
                    choicesRemaining--;
                    if (choicesRemaining == 0) // checks to make sure choices remain. if none remain it exits the selection form
                    {
                        this.Close();
                    }
                    selectionsRemainingLabel.Text = "Selections remaining: " + choicesRemaining.ToString();
                    break;
                    

                case DialogResult.No:
                    break;

                default:
                    MessageBox.Show("Nothing was pressed?!?!");
                    break;
            }

        } //end SelectionDialog

        private void blackbeltDeckSelection_Click(object sender, EventArgs e)
        {
            SelectionDialog("Black Belt");
        }

        private void blackmageDeckSelection_Click(object sender, EventArgs e)
        {
            SelectionDialog("Black Mage");
        }

        private void fighterDeckSelection_Click(object sender, EventArgs e)
        {
            SelectionDialog("Fighter");
        }

        private void redmageDeckSelection_Click(object sender, EventArgs e)
        {
            SelectionDialog("Red Mage");
        }

        private void thiefSelectionBox_Click(object sender, EventArgs e)
        {
            SelectionDialog("Thief");
        }

        private void whitemageDeckSelection_Click(object sender, EventArgs e)
        {
            SelectionDialog("White Mage");
        }

        public void WhichDeck(string selected)
        {
            //figure out whick deck was selected so we can run the right deck builder
            switch (selected)
            {
                case "Black Belt":
                    BlackBeltDeck(playerDeck);
                    break;

                case "Black Mage":
                    BlackMageDeck(playerDeck);
                    break;

                case "Fighter":
                    FighterDeck(playerDeck);
                    break;

                case "Red Mage":
                    RedMageDeck(playerDeck);
                    break;

                case "Thief":
                    ThiefDeck(playerDeck);
                    break;

                case "White Mage":
                    WhiteMageDeck(playerDeck);
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

        private void BlackBeltDeck(List<Card> playerDeck)
        {
            // Card stat arrays for Black Belt
            string[] name = { "Punch", "Punch", "Nunchuck", "Nunchuck", "Nunchuck", "Power Up" };
            int[] type = { 1, 1, 1, 1, 1, 4 };
            double[] value = { 2, 2, 3, 3, 3, 1 };
            int[] image = { 1, 1, 2, 2, 2, 3};

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                Card playerCard = new Card(); // Figured out I need to reinitialize this or if fouls up
                playerCard.CardName = name[i]; // get card name
                playerCard.CardType = type[i]; // get the card type
                playerCard.CardValue = value[i]; // get the card's value
                playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                playerDeck.Add(playerCard);
            }
        }

        private void BlackMageDeck(List<Card> playerDeck)
        {
            // Card stat arrays for 
            string[] name = { "Staff", "Staff", "Ice", "Fire", "Nuke", "Staff" };
            int[] type = { 1, 1, 1, 1, 1, 1 };
            double[] value = { 0, 0, 2, 2, 10, 0 };
            int[] image = { 7, 7, 4, 5, 6, 7};

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                Card playerCard = new Card(); // reinitialize
                playerCard.CardName = name[i]; // get card name
                playerCard.CardType = type[i]; // get the card type
                playerCard.CardValue = value[i]; // get the card's value
                playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                playerDeck.Add(playerCard);
            }
        }

        private void FighterDeck(List<Card> playerDeck)
        {
            // Card stat arrays for 
            string[] name = { "Silver Axe", "Silver Axe", "Silver Axe", "Shield", "Shield", "Great Axe" };
            int[] type = { 1, 1, 1, 3, 3, 1 };
            double[] value = { 2, 2, 2, 2, 2, 5 };
            int[] image = { 8, 8, 8, 9, 9, 10};

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                Card playerCard = new Card(); // reinitialize
                playerCard.CardName = name[i]; // get card name
                playerCard.CardType = type[i]; // get the card type
                playerCard.CardValue = value[i]; // get the card's value
                playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                playerDeck.Add(playerCard);
            }
        }

        private void RedMageDeck(List<Card> playerDeck)
        {
            // Card stat arrays for 
            string[] name = { "Short Sword", "Short Sword", "Lightning", "Cure", "Shield", "Double Cast" };
            int[] type = { 1, 1, 1, 2, 3, 5 };
            double[] value = { 1, 1, 2, 3, 1, 3 };
            int[] image = { 11, 11, 12, 13, 14, 15};

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                Card playerCard = new Card(); // reinitialize
                playerCard.CardName = name[i]; // get card name
                playerCard.CardType = type[i]; // get the card type
                playerCard.CardValue = value[i]; // get the card's value
                playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                playerDeck.Add(playerCard);
            }
        }

        private void ThiefDeck(List<Card> playerDeck)
        {
            // Card stat arrays for 
            string[] name = { "Dagger", "Dagger", "Dagger", "Weaken", "Weaken", "Critical Hit" };
            int[] type = { 1, 1, 1, 4, 4, 1 };
            double[] value = { 1, 1, 1, 3, 3, 3 };
            int[] image = { 16, 16, 16, 17, 17, 18};

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                Card playerCard = new Card(); // reinitialize
                playerCard.CardName = name[i]; // get card name
                playerCard.CardType = type[i]; // get the card type
                playerCard.CardValue = value[i]; // get the card's value
                playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                playerDeck.Add(playerCard);
            }
        }

        private void WhiteMageDeck(List<Card> playerDeck)
        {
            // Card stat arrays for 
            string[] name = { "Hammer", "Hammer", "Heal", "Heal", "Protect", "Hammer" };
            int[] type = { 1, 1, 2, 2, 3, 1 };
            double[] value = { 1, 1, 5, 5, 4, 1 };
            int[] image = { 19, 19, 20, 20, 21, 19};

            // Put the arrays into the deck
            for (int i = 0; i < name.Length; i++)
            {
                Card playerCard = new Card(); // reinitialize
                playerCard.CardName = name[i]; // get card name
                playerCard.CardType = type[i]; // get the card type
                playerCard.CardValue = value[i]; // get the card's value
                playerCard.CardImage = image[i]; // get the card image index

                // Add cards to the Deck (list) as we create them
                playerDeck.Add(playerCard);
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

        private void DeckSelection_Load(object sender, EventArgs e)
        {
            choicesRemaining = 4; // Need to reset this if a player gets game over and wants to play again.
            selectionsRemainingLabel.Text = "Selections remaining: " + choicesRemaining.ToString();
        }
    }
}
