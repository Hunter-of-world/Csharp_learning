using System.Security.Cryptography;

class  Program
{
    static void Main()
    {
        string userName = null;
        string Password = null;
        System.Console.Write("*******zaid banks *********");
        System.Console.Write("Enter your username: ");
        userName = System.Console.ReadLine();
        if (userName != null)
        {
            System.Console.Write("Enter your password: ");
            Password = System.Console.ReadLine();
        }
        System.Console.Write("you have signed in");
        System.Console.Write("main menu");
        System.Console.Write("*********");
        System.Console.WriteLine("1.cirdet ammount");
        System.Console.WriteLine("2.bank ploicy");
        System.Console.WriteLine("3.coustemr servce");
        System.Console.WriteLine("0.exit");
        System.Console.WriteLine("*********");
        
        
    }
}