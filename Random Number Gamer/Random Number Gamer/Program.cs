using System;
using System.Threading;

namespace Lernatelier
{
    class Program
    {
        static void Main(string[] args)
        {
            int highscore = 100000;
            
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;

                int Number = new Random().Next(1, 100);
                int Attempts = 1;
                Program Text = new Program();

                Text.Write("I thougt of a number. \nIf you want to guess it type '1' \nIf you dont want to guess it type 0\n");

                string input = Console.ReadLine();
                int userNumber = Convert.ToInt32(input);

                if (userNumber != 1)
                {
                    Environment.Exit(1);
                }

                Text.Write("Please type in a number between 1 and 100\n");

                while (userNumber != Number)
                {
                    try
                    {
                        if (Attempts == 1)
                        {
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                            Attempts++;
                        }

                        while ((userNumber < 1) | (userNumber > 100))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Text.Write("Error, your number needs to be between 1 and 100\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                        }

                        if (userNumber > Number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Text.Write("Your number is too high...\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                            Attempts++;

                        }
                        if (userNumber < Number)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Text.Write("Your number is too small...\n");
                            Console.ForegroundColor = ConsoleColor.White;
                            input = Console.ReadLine();
                            userNumber = Convert.ToInt32(input);
                            Attempts++;

                        }
                    }
                    catch
                    {
                        Text.Write("That is not a number!\n _______________________\n Please type in a number\n");
                    }

                }

                Attempts++;

                if (Attempts > 2)

                {
                    Attempts = Attempts -2;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Text.Write("Amazing, you guessed the right number!! You had " + Attempts + " Attempts\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(Figgle.FiggleFonts.Ogre.Render("You Won!!"));

                }

                else if (Attempts == 2)

                {
                    Text.Write("Amazing, you guessed the number first try\n");
                }

                if(Attempts < highscore)
                {
                    highscore = Attempts;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Text.Write("Your new Highscore is "+ highscore+ "!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    Console.ForegroundColor= ConsoleColor.DarkYellow;
                    Text.Write("Your current Highscore is " +highscore+ "!\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                if(highscore == 1)
                {
                    Text.Write("You have The best Higscore that is possible!  \n Do you want to reset the Highscore? Type y/n. \n");
                    if(Console.ReadLine() == "y" )
                    {
                        Text.Write("Your Highscore is now resetted!\n");
                        highscore = 100000;
                    }
                    
                }

                Text.Write("If you want to play again type 'retry' \n");

            } while (Console.ReadLine() == "retry");

            Environment.Exit(1);

             
        }

        
        public void Write(string text)
        {
            char[] chars = text.ToCharArray();

            foreach (char item in chars)
            {
                Console.Write(item);
                Thread.Sleep(80);
            }
        }

    }
}