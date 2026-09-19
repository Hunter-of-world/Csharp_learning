class Program
{
    public static void Main()
    {
        //create objects
        Product p1 = new Product();
        Product p2 = new Product();
        Product p3 = new Product();

        //intilize fields
        p1.productID = 1;
        p1.productName = "Iphone X";
        p1.productPrice = 5000;
        p2.productID = 2;
        p2.productName = "Samsung Galaxy X";
        p2.productPrice = 5000;
        p3.productID = 3;
        p3.productName = "mac";
        p3.productPrice = 5000;
        //print them
        //product 1
        System.Console.WriteLine(p1.productID);
        System.Console.WriteLine(p1.productName);
        System.Console.WriteLine(p1.productPrice);
        //product 2
        System.Console.WriteLine(p2.productID);
        System.Console.WriteLine(p2.productName);
        System.Console.WriteLine(p2.productPrice);
        //product 3
        System.Console.WriteLine(p3.productID);
        System.Console.WriteLine(p3.productName);
        System.Console.WriteLine(p3.productPrice);
    }
}