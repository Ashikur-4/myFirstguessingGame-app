using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Getappinfo(); //run app info

            Greetuser(); //ask user name and greet

           


            while (true)
            {

                //int correctnum = 7;

                // creat  a new random number
                Random random = new Random();

                //init correct number
                int correctnum = random.Next(1, 10);

                //init guess var
                int guess = 0;

                //ask user for a number
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Guess a number between 1 and 10... ");
                Console.ResetColor();

                //while guess is not correct
                while (guess != correctnum)
                {
                    //get user input
                    string inputnum = Console.ReadLine();

                    //make sure its a number
                    if (!int.TryParse(inputnum, out guess))
                    {
                        //print error message
                        printcolour(ConsoleColor.Red, "please use an actual number");

                        //keep going 
                        continue;
                    }


                    //cast to int and put in guess

                    guess = Int32.Parse(inputnum);

                    //match guess to correctnumber
                    if (guess != correctnum)
                    {
                        // set error

                        printcolour(ConsoleColor.Red, "wrong number , please try again");

                    }

                }
                //output succes message

                printcolour(ConsoleColor.Yellow, "Correct buddy..... !!..you guessed it");
                //ask to play again
                Console.WriteLine("Play Again ? [Y or N ]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Have a great day...!!");
                    Console.ResetColor();
                    return;
                }
                else
                {
                    return;
                }


            }









        }

        static void Getappinfo()
        {
            string AppName = "Number Guesser";
            string AppVersion = "1.0.0";
            string AppAuthor = "Ashikur Rahman";

            //change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            //writeout appinfo
            Console.WriteLine("{0} : version {1} by {2} ", AppName, AppVersion, AppAuthor);

            //reset text colour;
            Console.ResetColor();
        }

        static void Greetuser()
        {
            //ask user name
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("whats your name buddy ? ");
            Console.ResetColor();

            //get user input

            string inputname = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("hello {0}, lets play a game ....", inputname);

            Console.ResetColor();
        }

        static void printcolour(ConsoleColor color, string message)
        {
            //change text colour
            Console.ForegroundColor = color ;

            //tell user its not a number
            Console.WriteLine(message);

            //reset text colour;
            Console.ResetColor();
        }

    }
}
