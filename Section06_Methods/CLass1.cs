public class Product
{

    private int productID;
    private string productName;
    private double productPrice;
    public int quantityInStock; 
    private double tax;
    private static int totalQuantity;
    //declaring a new type of field (static field)
    //fields can be access in the same filed with writing the class name or with it 
    public static int totalProducts;
    //declaring a new type of field (const field)
    public const string categoryName = "Electronics";
    //declaring a new type of field (readonly field)
    public readonly string dateOfPurchase;
    //constructor 
    public Product()
    {
        dateOfPurchase = System.DateTime.Now.ToShortDateString();
    }
    //methods
    //set method for productID
    public void SetProductID(int value)
    {
        productID = value;
    }
    //get method for productID
    public int GetProductID()
    {
        return productID;
    }
    //set method for productName
    public void SetProductName(string value)
    {
        productName = value;
    }
    //get method for productName
    public string GetProductName()
    {
        return productName;
    }
    //set method for productPrice
    public void SetProductPrice(double value)
    {
        productPrice = value;
    }
    //get method for productPrice
    public double GetProductPrice()
    {
        return productPrice;
    }
    //set method for tax
    public void SetTax(double value)
    {
        tax = value;
    }
    //get method for tax
    public double GetTax()
    {
        return tax;
    }
    //set method for quantityInStock
    public void SetQuantityInStock(int value)
    {
        quantityInStock = value;
    }
    //get method for quantityInStock
    public int GetQuantityInStock()
    {
        return quantityInStock;
    }
    //get method for dateOfPurchase
    public string GetDateOfPurchase()
    {
        return dateOfPurchase;
    }
    //new static method
    //static set method for total Products
    public static void SetTotalProducts(int value)
    {
        totalProducts = value;
    }
    //static get method for total Products
    public static int GetTotalProducts()
    {
        return totalProducts;
    }
    //static method to calculate total quantity
    public static int GetTotalQuantity(Product p1, Product p2, Product p3)
    {
        int total;
        total=p1.GetQuantityInStock() + p2.GetQuantityInStock() + p3.GetQuantityInStock();
        return total;
    }
 
    /*cost <= 20000 than tax = 10%
     cost > 20000 than tax = 12.5%*/
    public void CalculateTax(double percentage = 4.5) //setting up a default value
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
            t = productPrice * percentage / 100;
        }

        tax = t;
    }
    //new overloading method
    public void CalculateTax(double productPrice ,double percentage)
    {
        //local variable (its only access able in the same method )
        double t;
        
        //calculate tax 
        if (productPrice <= 50000)
        {
            t = productPrice * 5 / 100;
        }
        else
        {
            t = productPrice * percentage / 100;
        }
    }

}