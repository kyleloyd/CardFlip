using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFlip
{
    class Card
    {
        // State of card;
        // 0 = Not flipped; 1 = Flipped; 2 = Flagged;
        private int state;

        // Value of the card
        private int value;

        // Holds the value for whether the tile is a 
        // bomb or not; 0 = No, 1 = Yes;
        private int isBomb;

        private Random getRandom = new Random();

        /// <summary>
        /// Returns the value of the card the method is called upon.
        /// </summary>
        /// <returns>value</returns>
        public int getValue() 
        {
            return value;
        }

        /// <summary>
        /// Returns whether or not the card has been flipped.
        /// </summary>
        /// <returns>flipped</returns>
        public int checkState() 
        {
            return state;
        }

        /// <summary>
        /// Changes the active card's status to flipped.
        /// </summary>
        public void flipCard() 
        {
            state = 1;
        }

        /// <summary>
        /// Checks if the "isBomb" flag is true for the
        /// card called upon.
        /// </summary>
        public int checkIfBomb()
        {
            return isBomb;
        }

        public Card() 
        {
            state = 0;
            value = getRandom.Next(1, 4);
            if (value == 1) 
            {
                isBomb = getRandom.Next(2);
            } 
        }
    }
}
