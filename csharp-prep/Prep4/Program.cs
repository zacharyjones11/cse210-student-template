using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberlist = new List<int>();
        int number = -1;

        while (number != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished");
            string user = Console.ReadLine();
            number = int.Parse(user);

            if (number != 0)
            {
                numberlist.Add(number);
            }
        }

        if (numberlist.Count > 0 || numberlist.Count < 0)
        {
            int sum = 0;
            int largest = numberlist[0]; 
        
        
            foreach (int index in numberlist)
            {
                sum += index;
                if (index > largest)
                {
                    largest = index;
                }
            }
            double average = (double)sum / numberlist.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");
        }
    }
}