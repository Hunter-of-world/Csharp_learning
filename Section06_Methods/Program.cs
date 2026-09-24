class Program
{
    public static void Main()
    {
        //local constant
        const string developerName = "zaid";
        //create objects
        Product p1 = new Product();
        //accessing the new field through the product class (not through an object)
        Product.SetTotalProducts(Product.GetTotalProducts()+1); //first adding using static method
        Product p2 = new Product();
        Product.SetTotalProducts(Product.GetTotalProducts()+1); //second adding using static method
        Product p3 = new Product();
        Product.SetTotalProducts(Product.GetTotalProducts()+1); //third adding using static method

        //intilize fields and Encapsulation
        p1.SetProductID(1);
        p1.SetProductName("Iphone X");
        p1.SetProductPrice(20000);
        p1.SetQuantityInStock(2000);
        p2.SetProductID(2);
        p2.SetProductName("Samsung Galaxy X");
        p2.SetProductPrice(7500);
        p2.SetQuantityInStock(1475);
        p3.SetProductID(3);
        p3.SetProductName("mac");
        p3.SetProductPrice(9000) ;
        p3.SetQuantityInStock(799);
        
        //call methods (tax method using default arguments )
        p1.CalculateTax(9.2);
        p2.CalculateTax(7.5);
        p3.CalculateTax(); //there will br a default value from the arguments which is 4.5
        
        //print them
        //product 1
        System.Console.WriteLine(p1.GetProductID());
        System.Console.WriteLine(p1.GetProductName());
        System.Console.WriteLine("the product price is: "+ p1.GetProductPrice());
        System.Console.WriteLine("the quantity of this product is: "+p1.GetQuantityInStock());
        System.Console.WriteLine("the date of purchase is "+p1.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + p1.GetTax());

        //product 2
        System.Console.WriteLine(p2.GetProductID());
        System.Console.WriteLine(p2.GetProductName());
        System.Console.WriteLine("the product price is: "+ p2.GetProductPrice());
        System.Console.WriteLine("the quantity of this product is: "+p2.GetQuantityInStock());
        System.Console.WriteLine("the date of purchase is "+p2.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + p2.GetTax());

        //product 3
        System.Console.WriteLine(p3.GetProductID());
        System.Console.WriteLine(p3.GetProductName());
        System.Console.WriteLine("the product price is: "+ p3.GetProductPrice());
        System.Console.WriteLine("the quantity of this product is: "+p3.GetQuantityInStock());
        System.Console.WriteLine("the date of purchase is "+p3.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + p3.GetTax());
        //storing all of them in one 
        double totalPrice = p1.GetProductPrice() + p2.GetProductPrice() + p3.GetProductPrice();
        System.Console.WriteLine("the total price of all products is: "+ totalPrice);
        //comparing which one have the highst price
        if(p1.GetProductPrice() > p2.GetProductPrice() && p2.GetProductPrice() > p3.GetProductPrice() )
        {
            System.Console.WriteLine( "p1 is the highest price ");
        }else if (p2.GetProductPrice() > p1.GetProductPrice() && p2.GetProductPrice() > p1.GetProductPrice())
        {
            System.Console.WriteLine( "p2 is the highest price ");
        }
        else
        {
            System.Console.WriteLine( "p3 is the highest price ");
        }
        //total quantity
        int totalQuntity = Product.GetTotalQuantity(p1,p2,p3);
        System.Console.WriteLine("the total quantity of all products is: "+Product.GetTotalQuantity(p1, p2, p3));
        //Pulling the static field through class name . name of the field
        System.Console.WriteLine("the total number of products is: " + Product.GetTotalProducts());
        //Pulling the const field (we cant change it from here like the static fields it can only be change from the same class)
        System.Console.WriteLine("the Categorty of the products is: "+   Product.categoryName);
    } 
}
