using System;

namespace Zahlenrätzel_Lernatelier
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            bool wiederholen = true;

            int minimum = 1;
            int maximum = 100;
            int guess;
            int Zahl;
            int guesses;

            String response;

            while (wiederholen)
            {
                guess = 0;
                guesses = 0;
                response = "";
                Zahl = random.Next(minimum, maximum + 1);

                try
                {
                    while (guess != Zahl)
                    {
                        Console.WriteLine("Geben sie eine Zahl zwischen " + minimum + " - " + maximum + " ein : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Zahl: " + guess);

                        if (guess > Zahl)
                        {
                            Console.WriteLine(guess + " ist zu hoch");
                        }
                        else if (guess < Zahl)
                        {
                            Console.WriteLine(guess + " ist zu klein");
                        }
                        guesses++;

                    }
                    Console.WriteLine("Richtige Zahl!");
                    Console.WriteLine("Anzahl versuche: " + guesses);


                    Console.WriteLine("Wenn du nochmals spielen willst drücke S. Wenn nicht drücke N: ");
                    response = Console.ReadLine();
                    response = response.ToUpper();

                    if (response == "S")
                    {
                        wiederholen = true; 
                    }
                    else
                    {
                        wiederholen = false;
                    }

                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Geben sie bitte das von ihnen geforderte ein!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.ReadKey();







            }
        }
    }
}
