using System;

namespace AronGibsonDeliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string again;
            do
            {
                Console.WriteLine("What measurement type do you want to convert?");
                string measurement = Console.ReadLine().ToLower();
                Console.WriteLine("Enter amount.");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (measurement == "fidget spinners" || measurement == "fidget spinner")
                {
                    double answer = amount / 3.5;
                    Console.WriteLine(amount + " fidget spinners = " + answer + " inches.");
                }
                else if (measurement == "inches" || measurement == "inch")
                {
                    double answer = amount * 3.5;
                    Console.WriteLine(amount + " inches = " + answer + " fidget spinners.");
                }
                else if (measurement == "memes" || measurement == "meme")
                {
                    double answer = amount / 5;
                    Console.WriteLine(amount + " memes = " + answer + " feet.");
                }
                else if (measurement == "feet" || measurement == "foot")
                {
                    double answer = amount * 5;
                    Console.WriteLine(amount + " feet = " + answer + " memes.");
                }

                Console.WriteLine("Do another calculation?");
                again = Console.ReadLine().ToLower();

            } while (again == "yes");
            Console.WriteLine("Ending program.");
        }
    }
}
