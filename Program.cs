using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication23
{
    class Program
    {
            static void Main(string[] args)
             {  // Loop to continue program, as user answers question...
                bool run = true;
                // Title of the project....
                Console.WriteLine("Please Play Pig Latin Translator!");

                do
                {   //Variables expressed from gathered input
                    Console.Write("\nEnter a word to be translated: ");
                    string userWord = Console.ReadLine();
                    string[] createdWord = userWord.Split(' ');
                    Translation(createdWord);
                    run = Cont();

                } while (run == true);

            }
        //Method used to verify user length and 
        public static void Translation(string[] userWord)
        {   //Expression to determine parameters - start, range and number of increments
            for (int i = 0; i < userWord.Length; i++)
            {   //possibilities / logic of method to use for Vowels
                if (userWord[i].StartsWith("a") || userWord[i].StartsWith("e") || userWord[i].StartsWith("i") || userWord[i].StartsWith("o") || userWord[i].StartsWith("u"))
                {
                    Console.Write(userWord[i] + "way ");
                }

                else
                {   //subtracting the letters & and adding the translation
                    int pos = userWord[i].IndexOfAny(new char[] { 'a', 'e', 'i', 'o', 'u', 'y' });

                    string translation = userWord[i].Substring(0, pos);

                    string userWord1 = userWord[i] + translation;

                    string createdWord = userWord1.Remove(0, pos);

                    Console.Write(createdWord + "ay ");

                }

            }
        }

        public static bool Cont()
        {   // users option to conitnue or quit game
            bool run = true;
            Console.Write("\n\nContinue?(y/n) ");
            string cont = Console.ReadLine();


            if (cont == "n")
            {
                Console.WriteLine("\nNice Job!");
                run = false;
            }
            return run;
        }
    }
}
        
