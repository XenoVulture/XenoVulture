using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AndrewRusso_CPT_185_Final_Project
{
    public class Card
    {
        // Constructor
        public Card()
        {
            CardName = ""; // Name of the card
            CardType = 0; // What type of card this is (what it does) *see key below*
            CardValue = 0.0; // How much does it does
            CardImage = 0; // Index of the card's image
        }

        // CardName property
        public string CardName { get; set; }

        /* Key for CardType
         * 1 - Attack
         * 2 - Heal (retore health)
         * 3 - Shield (absorbs damage)
         * 4 - Damage up (increase dmg player deals by .5 for (value) turns)
         * 5 - Energy up (adds player energy)
        */

        // CardType property
        public int CardType { get; set; }

        // CardValue property
        public double  CardValue { get; set; }  // This could be an int but I left it as double for continuation/update reasons.
                                                // originally this value could represent a damage increase of 2.5
                                                // other card types in the future may require a double

        // CardImage property
        public int CardImage { get; set; }
    }
}
