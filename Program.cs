using System;

namespace InfoSys.App
{
    class Program
    {
        static void Main(string[] args)
        {

            getAppInfo();

            greetsUser();

            //ask user name

           
            //Set correct number

            while (true)
            {

                Random random = new Random();

                int correctNumber = random.Next(1, 10);


                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {

                    string inputNum = Console.ReadLine();


                    if (!int.TryParse(inputNum, out guess))
                    {

                        printColMessage(ConsoleColor.Red, "Please use an actual number");


                        continue;


                    }



                    guess = Int32.Parse(inputNum);


                    if (guess != correctNumber)
                    {

                        printColMessage(ConsoleColor.Red, "Wrong number please try again");




                    }

                }


                printColMessage(ConsoleColor.Yellow, "You are CORRECTTT YOU GUESSED IT");


                Console.WriteLine("Play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if(answer == "N")
                {

                    return;
                }

                else
                {
                    return;
                }


            }

        }

        // get app and display app info
        static void getAppInfo()
        {

            //set app variables 
            string appname = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Adrien Allen";

            //change text color

            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info

            Console.WriteLine("{0}: Version {1} by {2}", appname, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();



        }

        //asks users name and greet
        static void greetsUser()
        {

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", inputName);

        }

        static void printColMessage(ConsoleColor color, string message)
        {

            Console.ForegroundColor = color;

            Console.WriteLine(message);


            Console.ResetColor();

        }
    }
}
