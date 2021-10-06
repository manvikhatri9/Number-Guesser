using System;

//Namespace
namespace NumberGusser
{
    //Main Class
    class Program
    {
        //Entry point Method
        static void Main(string[] args)
        {
            GetAppInfo();     //Run GetAppInfo function to get info about the name, version and author name
            //Application Details
            //string appName = "Number Guesser";
            //string appVersion = "1.0.0.3";
            //string appAuthor = "Manvi Khatri";

            //Changing the color of text to green
            //Console.ForegroundColor = ConsoleColor.Green ;

            //Write about application details
            //Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Back to the white color of the text
            //Console.ResetColor();

            GreetUser();     //Run GreetUser function to know the name of the user

            //Ask for the name of the user
            //Console.WriteLine("What is your name?");
            //string inputName = Console.ReadLine();
            //Console.WriteLine("Hello {0}, let us play a game!", inputName);
            //Console.ReadLine();

            while (true)
            {
                //init correct number
                //int correctNumber=7;

                //Create a new random object
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;          //by default 0

                //Ask for a number
                Console.WriteLine("Enter number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change the color of the text
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its not the number
                        Console.WriteLine("Please enter a actual number!");

                        Console.ResetColor();
                        continue;
                    }
                    //cast to int and put in guess
                    guess = Int32.Parse(input);         /*Converts the string representation of a number
                                                    in a specified style and culture-specific format 
                                                    to its 32-bit signed integer equivalent.*/
                    //Match guess to correct number
                    if (guess != correctNumber)
                    {

                        //Change the color of the text
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Tell user its the wrong number
                        Console.WriteLine("Wrong Number, please try again!");

                        Console.ResetColor();
                    }
                }

                //change the color of the text
                Console.ForegroundColor = ConsoleColor.Blue;

                //Tell user its the correct number
                Console.WriteLine("The number entered is correct");
                Console.ReadLine();

                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                //Get Answer 
                string answer = Console.ReadLine().ToUpper();
                if (answer=="Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()     //Get and display application info
        {
            //Application Details
            string appName = "Number Guesser";
            string appVersion = "1.0.0.3";
            string appAuthor = "Manvi Khatri";

            //Changing the color of text to green
            Console.ForegroundColor = ConsoleColor.Green;

            //Write about application details
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Back to the white color of the text
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask for the name of the user
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, let us play a game!", inputName);
            Console.ReadLine();

        }
    }
}
