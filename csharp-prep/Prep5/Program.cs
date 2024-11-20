using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMsg();
        string Name = PromptUserName();
        int CoolNumb = PromptUserNumber();
        double SquaredNumb = SquareNumber(CoolNumb);
        DisplayResult(Name, CoolNumb, SquaredNumb);
    }

    static void DisplayMsg()
    {
        Console.WriteLine("What up Gang!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your hood name?");
        string UserName = Console.ReadLine();

        return UserName;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Gimme yo fav numba g.");
        string user = Console.ReadLine();
        int dopenumber = int.Parse(user);

        return dopenumber;
    }
    static int SquareNumber(int dopenumber)
    {
        return dopenumber * dopenumber;
    }
    static void DisplayResult(string Name,int CoolNumb,double SquaredNumb)
    {
        Console.WriteLine($"Yo name is: {Name}");
        Console.WriteLine($"Yo fav numba is: {CoolNumb}");
        Console.WriteLine($"{Name}, yo fav numba squared is: {SquaredNumb}");
    }
}
