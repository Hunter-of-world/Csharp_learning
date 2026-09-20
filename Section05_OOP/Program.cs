using System.Runtime.Serialization;
using System.Security.Cryptography;

class Program
{
    public static void Main()
    {
        //local constant
        const string developerName = "zaid";
        //create reference variables
        Product p1 = new Product();
        //accessing the new field through the product class (not through an object)
        Product.TotalProducts++; //first adding
        Product p2 = new Product();
        Product.TotalProducts++; //second adding
        Product p3 = new Product();
        Product.TotalProducts++; //third adding

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
        System.Console.WriteLine("the date of purchase is "+p1.DateOfPurchase);
        //product 2
        System.Console.WriteLine(p2.productID);
        System.Console.WriteLine(p2.productName);
        System.Console.WriteLine(p2.productPrice);
        System.Console.WriteLine("the date of purchase is "+p2.DateOfPurchase);
        //product 3
        System.Console.WriteLine(p3.productID);
        System.Console.WriteLine(p3.productName);
        System.Console.WriteLine(p3.productPrice);
        System.Console.WriteLine("the date of purchase is "+p3.DateOfPurchase);
        //storing all of them in one 
        double totalPrice = p1.productPrice + p2.productPrice + p3.productPrice;
        System.Console.WriteLine("the total price of all products is: "+ totalPrice);
        //comparing which one have the highst price
        if(p1.productPrice > p2.productPrice && p2.productPrice > p3.productPrice )
        {
            System.Console.WriteLine( "p1 is the highest price ");
        }else if (p2.productPrice > p1.productPrice && p2.productPrice > p1.productPrice)
        {
            System.Console.WriteLine( "p2 is the highest price ");
        }
        else
        {
            System.Console.WriteLine( "p3 is the highest price ");
        }
        //Pulling the static field through class name . name of the field
        System.Console.WriteLine("the total number of products is: " + Product.TotalProducts);
        //Pulling the const field (we cant change it from here like the static fields it can only be change from the same class)
        System.Console.WriteLine("the Categorty of the products is: "+   Product.CategoryName);
    } 
}
