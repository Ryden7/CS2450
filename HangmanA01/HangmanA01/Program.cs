using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Rizwan Mohammed on 9/10/2016
//CS 2450
namespace Hangman
{
    class Program
    {
        //The hardcoded word can be entered here
        static void Main(string[] args)
        {
            hangmanGame("Mississippi");
        }

        /// <summary>
        /// A console application that plays the game Hangman
        /// </summary>
        /// <param name="word"></param>
        public static void hangmanGame(String word)
        {
            //Setting up what we need for later
            word = word.ToLower();
            int length = word.Length;
            int lives = 6;
            char[] asdf = word.ToCharArray();
            List<String> list = new List<String>();
            String check = "";
            bool correct = false;



            //Fills in the blanks
            for (int i = 0; i < length; i++)
            {
                list.Add("_ ");


            }

            //Check the number of lives
            while (lives > 0)
            {
                check = "";
                //On each iteration, check the word
                foreach (var item in list)
                {
                    Console.Write(item);
                    check += item;

                }

                //If the word is guessed, break
                if (check.Replace(" ", "") == word)
                {
                    correct = true;
                    Console.WriteLine();
                    Console.WriteLine();
                    break;
                }

                //The user input
                Console.WriteLine("(lives left: " + lives + ")");
                Console.Write("Your guess: ");
                char guess = Console.ReadKey().KeyChar;
                Console.WriteLine();

                //If a letter is guessed correctly, replace the appropriate blank with the letter
                if (word.Contains(guess))
                {
                    for (int i = 0; i < asdf.Length; i++)
                    {
                        if (asdf[i].Equals(guess))
                            list[i] = guess.ToString() + " ";

                    }


                }
                //decrement lives
                else
                {
                    lives--;
                }
            }

            //If we won
            if (correct == true)
                Console.WriteLine("Congratulations!");

            //if we lost
            else
            {
                Console.WriteLine();
                Console.WriteLine("The word was " + word + " - try again");

            }

            Console.Read();
        }
    }
}
