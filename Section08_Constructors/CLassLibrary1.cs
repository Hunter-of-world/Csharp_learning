public class Employee
{
    //Fields
    public int empID;
    public string empName;
    public string empJob;
    
    //static Fields
    public static string companyName;
    
    //constructors 
    public Employee(int empID, string empName, string empJob)
    {
        this.empID = empID;
        this.empName = empName;
        this.empJob = empJob;
    }

    //static constructors
    static Employee()
    {
            companyName = "computiq";
    }
    
}