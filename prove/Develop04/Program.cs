using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        { 
            
            Console.Clear();

            Console.WriteLine("Please choose one of the following excerises: ");
            Console.WriteLine("1. Breathing Activity");            
            Console.WriteLine("2. Reflection Activty");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new();
                    breathing.Run();
                    break;

                case "2":
                    Reflection reflect = new();
                    reflect.Run();
                    break;

                case "3":
                    Listing listing = new();
                    listing.Run();
                    break;
                
                case "4":
                    keepRunning = false;
                    break;
                
                default:
                    Console.WriteLine("\nInvalid choice, please type a numnber 1-4.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
            }
        }

    }
}