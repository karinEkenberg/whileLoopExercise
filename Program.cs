/*
Övning 6: Menyprogram med while: Skapa ett menyprogram som innehåller följande alternativ:
Välj ett av följande alternativ.
1. Omvandla meter till kilometer
2. Omvandla kilometer till meter
3. Avsluta programmet
 */
namespace whileLoopExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool myBool = true;
            while (myBool)
            {
                Console.WriteLine("Welcome! Transform from meters to kilometers and vice versa:");
                Console.WriteLine("[1] - Meters to kilometers.");
                Console.WriteLine("[2] - Kilometers to meters.");
                Console.WriteLine("[3] - Exit program.");
                double meters, kilometers, result;
                double.TryParse(Console.ReadLine(), out double input);
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Enter amount of meters to transform into kilometers:");
                    if (double.TryParse(Console.ReadLine(),out meters))
                    {
                        result = meters / 1000;
                        Console.WriteLine($"{meters} meters is {result} kilometers.");
                    }
                    else { LoopyLoop.ErrorMessage("Wrong input.."); continue; }
                }
                else if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Enter amount of kilometers to transform into meters:");
                    if (double.TryParse(Console.ReadLine(), out kilometers))
                    {
                        result = kilometers * 1000;
                        Console.WriteLine($"{kilometers} kilometers is {result} meters.");
                    }
                    else { LoopyLoop.ErrorMessage("Wrong input.."); continue; }
                }
                else if (input == 3)
                {
                    LoopyLoop.Exit();
                    break;
                }
                else 
                {
                    LoopyLoop.ErrorMessage("Wrong input..");
                    continue; 
                }
            }
        }

        class LoopyLoop
        {
            public static void Exit()
            {
                Console.Clear();
                Console.WriteLine("Thanks for this time! Shutting down...");
                Environment.Exit(0);
            }

            public static void ErrorMessage(string message)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
                Thread.Sleep(2000);
            }
        }
    }
}
