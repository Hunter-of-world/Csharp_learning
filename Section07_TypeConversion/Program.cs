class Program
{
    public static void Main()
    {
    //try parse
    string s;
    s=System.Console.ReadLine();

    int.TryParse(s, out int b);
    System.Console.WriteLine(b);
    }
}