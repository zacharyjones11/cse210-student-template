using System;

class Program
{
    static void Main(string[] args)
    /*What is your first name? Scott
      What is your last name? Burton

      Your name is Burton, Scott Burton.
    */
    {
        Console.WriteLine("What is your first name?");
        string givenname = Console.ReadLine();

        Console.WriteLine("What is your last name?");
        string sirname = Console.ReadLine();

        Console.WriteLine($"Your name is {sirname}, {givenname} {sirname}.");

    }
}