class Program
{
    static void Main()
    {
        Manger mgr1 = new Manger(100,"muklah","iraq.baghdad.karrada","coordination");
        System.Console.WriteLine("\nemployee id is "+mgr1.EmpId);
        System.Console.WriteLine("employee name is "+mgr1.EmpName);
        System.Console.WriteLine("employee location is "+mgr1.Location);
        System.Console.WriteLine("employee job is "+mgr1.DepartmentName);
        System.Console.WriteLine("the total sales of the year is " + mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine("he is "+mgr1.GetFullDepartmentName());
        System.Console.WriteLine("his "+mgr1.GetHealthInsuranceAmount());
        //base-typed reference to the same object
        Employee eRef = mgr1;
        System.Console.WriteLine("his "+eRef.GetHealthInsuranceAmount());


        //creating objects of the salesman class
        SalesMan sm1 = new SalesMan(103,"mahmood","iraq.baghdad.thalbaa","south");
        System.Console.WriteLine("\nemployee id is "+sm1.EmpId);
        System.Console.WriteLine("employee name is "+sm1.EmpName);
        System.Console.WriteLine("employee location is "+sm1.Location);
        System.Console.WriteLine("the total sales of the month is "  + sm1.GetTotalSalesOfTheMonth());
        
        //creating objects of the ProjectManger class
        ProjectManger pm1 = new ProjectManger(104,"farooq","iraq.baghdad.harthya",2,"lawyer");
        System.Console.WriteLine("\nemployee id is "+pm1.EmpId);
        System.Console.WriteLine("employee name is "+pm1.EmpName);
        System.Console.WriteLine("employee location is "+pm1.Location);
        
    }
}