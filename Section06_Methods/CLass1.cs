public class Product
{

    public int productID;
    public string productName;
    public double productPrice;

    public double tax;
    //declaring a new type of field (static field)
    //fields can be access in the same filed with writing the class name or with it 
    public static int TotalProducts;
    //declaring a new type of field (const field)
    public const string CategoryName = "Electronics";
    //declaring a new type of field (readonly field)
    public readonly string DateOfPurchase;
    //constructor 
    public Product()
    {
        DateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
    //method 
    /*cost <= 20000 than tax = 10%
     cost > 20000 than tax = 12.5%*/
    public void CalculateTax()
    {
        //local variable (its only access able in the same method )
        double t;
        
        //calculate tax 
        if (productPrice <= 20000)
        {
            t = productPrice * 10 / 100;
        }
        else
        {
            t = productPrice * 12.5 / 100;
        }

        tax = t;
    }

}