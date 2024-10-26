using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new( new ScriptureReference("John", 3, 16), "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        );


        while(!scripture.AllHiddenWords)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            
            Console.WriteLine("\nPress enter to continue or type 'quit' to exit:");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
                break;

            // Hide random words when user presses enter
            scripture.HideRandomWords(3);
            
        }
    }
    
}

// create scripture object

// in a while loop: clear terminal
// Write to terminal
// Hide 3 words based on if the user types quit or presses enter
