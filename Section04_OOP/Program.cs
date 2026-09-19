using System.ComponentModel;

public class Sample
{
     static void Main()
     { 
         //crate objects
            Product product1,product2,product3;
            //create objects
            product1=new Product();
            product2=new Product();
            product3=new Product();
            //initalize fields
            product1.productID = 1001;
            product1.productName = "Phone";
            product1.productPrice = 30000;
            product1.quantityInStock=3;
            product2.productID = 1001;
            product2.productName = "Labtop";
            product2.productPrice = 20000;
            product2.quantityInStock=4;
            product3.productID = 1003;
            product3.productName = "Mobile";
            product3.productPrice = 45000;
            product3.quantityInStock=5;
            //get values from fields
            System.Console.WriteLine("Product 1");
            System.Console.WriteLine("Product ID: " + product1.productID);
            System.Console.WriteLine("Product Name: " + product1.productName);
            System.Console.WriteLine("Product Price: " + product1.productPrice);
            System.Console.WriteLine("Quantity In Stock: " + product1.quantityInStock);
            
            System.Console.WriteLine("Product ID: " + product2.productID);
            System.Console.WriteLine("Product Name: " + product2.productName);
            System.Console.WriteLine("Product Price: " + product2.productPrice);
            System.Console.WriteLine("Quantity In Stock: " + product2.quantityInStock);
            
            System.Console.WriteLine("Product ID: " + product3.productID);
            System.Console.WriteLine("Product Name: " + product3.productName);
            System.Console.WriteLine("Product Price: " + product3.productPrice);
            System.Console.WriteLine("Quantity In Stock: " + product3.quantityInStock);


     }
}