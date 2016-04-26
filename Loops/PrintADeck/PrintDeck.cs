/*04. Print a Deck
Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up to the card with the given sign(without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades.

Input
On the only line, you will receive the sign of the card to which, including, you should print the cards in the deck.

Output
The output should follow the format bellow(assume our input is 5):  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds 3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds ... 5 of spades, 5 of clubs, 5 of hearts, 5 of diamonds 

Constraints
The input character will always be a valid card sign.
 */

using System;

namespace PrintADeck
{
    class PrintDeck
    {
        static readonly string[] deckCards = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        static readonly string[] suits = new string[4] { "spades", "clubs", "hearts", "diamonds" };

        static void Main()
        {
            string input = Console.ReadLine();

            int index = Array.IndexOf(deckCards, input);

            for (int i = 0; i <= index; i++)
            {
                for (int j = 0; j < suits.Length; j++)
                {
                    string card = deckCards[i];
                    string suit = suits[j];

                    if (j == suits.Length - 1)
                    {
                        Console.Write("{0} of {1}", card, suit);
                    }
                    else
                    {
                        Console.Write("{0} of {1}, ", card, suit);
                    }

                }

                Console.WriteLine();
            }

        }
    }
}
