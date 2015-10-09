using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardFlip
{
    class Gameboard
    {
        // Multi-dim array holding 25 Card instance variables
        private Card[,] positionalValuesArray = new Card[5, 5];
        
        // Holds the total numerical value (addition) of each row;
        private int[] rowValues = new int[5];

        // Holds the total numerical value (addition) of each column; 
        private int[] columnValues = new int[5];

        // Holds the count of bombs held within each row;
        private int[] rowBombs = new int[5];

        // Holds the count of bombs held in each column;
        private int[] columnBombs = new int[5];

        public Gameboard() 
        {
            generateCards();
            populateValues();
        }

        /// <summary>
        /// Generates the values for each card and places them inside
        /// the positional array.
        /// </summary>
        private void generateCards()
        {
            for (int rowCounter = 0; rowCounter < 5; rowCounter++) 
            {
                for (int columnCounter = 0; columnCounter < 5; columnCounter++) 
                {
                    positionalValuesArray[rowCounter, columnCounter] = new Card();
                }
            }
        }

        /// <summary>
        /// Calculates the numerical value of each row on the game board.
        /// </summary>
        private void populateValues() 
        {
            for (int rowCounter = 0; rowCounter < 5; rowCounter++) 
            {
                for (int columnCounter = 0; columnCounter < 5; columnCounter++)
                {
                    Card currentCard = positionalValuesArray[rowCounter, columnCounter];

                    rowValues[rowCounter] += currentCard.getValue();
                    columnValues[columnCounter] += currentCard.getValue();

                    if (currentCard.checkIfBomb() == 1)
                    {
                        rowBombs[rowCounter] += 1;
                        columnBombs[columnCounter] += 1;
                    }
                }
            }
        }
    }
}
