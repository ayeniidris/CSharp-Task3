using Microsoft.VisualBasic.CompilerServices;
using System;

namespace Csharp_Task3
{
    class Program
    {
        static  int guessRemaining = 0;
      static  int actualNumber = 0;
        static void Main(string[] args)
        {
         
            Guessing();
           Console.ReadLine();
        }

        static void Guessing()
        {
            int level;
            Console.WriteLine("Enter Game Level\n 1.Easy\n 2.Medium\n 3.Hard");
            Console.Write("Enter Level Number: ");
            try
            {
                level = Convert.ToInt32(Console.ReadLine());

                // check if a user enter any number different from the specified numbers
             if((level!=1) && (level != 2) && (level != 3))
              {
                    Console.WriteLine("There are 3 levels, easy, medium and hard At easy, Users get a chance to " +
                   "guess the number between 1 - 10," +
                   " and the user gets 6 guessesMedium, the users is required to guess " +
                   "the number between 1 - 20, and the user gets 4 guessesHard, users " +
                   "are required to guess between 1 - 50, and they only get 3 guesses\n");
                    Console.Write("Do you wish to continue this game Yes or No?: ");
                    string accept = Console.ReadLine();
                    if (accept == "Yes")
                    {
                        Guessing();

                    }
                    else
                    {
                        return;
                    }

                }
                else
                {
                    //continue with the game and check for the level
                    if (level == 1)
                    {
                        guessRemaining = 6;
                        actualNumber = 7;
                        AcceptGuess(1,10);

                        //will call a method for accepting guessing number
                    }else if (level == 2)
                    {
                        guessRemaining = 4;
                        actualNumber = 16;
                        AcceptGuess(1, 20);

                        //will call a method for accepting guessing number
                    }
                    else if (level == 3)
                    {
                        guessRemaining = 3;
                        actualNumber = 33;
                        AcceptGuess(1, 50);

                        //will call a method for accepting guessing number
                    }
                    
                  

                }

            }
            catch (Exception)
            {
                Console.WriteLine("There are 3 levels, easy, medium and hard At easy, Users get a chance to " +
                    "guess the number between 1 - 10," +
                    " and the user gets 6 guessesMedium, the users is required to guess " +
                    "the number between 1 - 20, and the user gets 4 guessesHard, users " +
                    "are required to guess between 1 - 50, and they only get 3 guesses\n");
                Console.Write("Do you wish to continue this game Yes or No?: ");
                string accept = Console.ReadLine();
                if (accept == "Yes") { Guessing();

                }
                else
                {
                   return;
                }
            }

        }

        //another method
       static void AcceptGuess(int start, int end)
        {
            


            if (guessRemaining < 1) {
                Console.WriteLine("Game Over");
               Guessing();
            }
            Console.Write("Enter Number: ");
            int number= Convert.ToInt32(Console.ReadLine());
            //check for the number specified for level 1
            if (number>=start && number<=end)
            {
                //do the operation
                guessRemaining -= 1;
                if (number == actualNumber)
                {
                    Console.WriteLine("You are correct\nDo you wish to continue with the game Yes or No?");
                    string accept = Console.ReadLine();
                    if (accept == "Yes")
                    {
                        Guessing();
                    }

                }
                else
                {
                    if (guessRemaining == 0)
                    {
                        Console.WriteLine("Game over");
                        Guessing();
                    }
                    else if (guessRemaining == 1)
                    {
                        Console.WriteLine("That was wrong,You have " + guessRemaining + " guess remaining" + "\n guesses again");
                        AcceptGuess(start, end);
                    }
                    else
                    {

                        Console.WriteLine("That was wrong,You have " + guessRemaining + " guesses remaining" + "\n guesses again");
                        AcceptGuess(start, end);
                    }

                    
                }


            }
            else
            {
                Console.WriteLine("you are only allowed to enter from number "+start+" to "+ end);
                AcceptGuess(start, end);
            }

           

        }

    }

}