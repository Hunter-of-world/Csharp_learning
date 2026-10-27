class Program
{
    static void Main()
    {
        Manger mgr1 = new Manger(100,"muklah","iraq.baghdad.karrada","coordination");
        System.Console.WriteLine("\nemployee id is "+mgr1.EmpID);
        System.Console.WriteLine("employee name is "+mgr1.EmpName);
        System.Console.WriteLine("employee location is "+mgr1.Location);
        System.Console.WriteLine("employee job is "+mgr1.DepartmentName);
        System.Console.WriteLine("the total sales of the year is " + mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine("she is "+mgr1.GetFullDepartmentName());
        System.Console.WriteLine("her "+mgr1.GetHealthInsuranceAmount());
        //base-typed reference to the same object


        //creating objects of the salesman class
        SalesMan sm1 = new SalesMan(103,"mahmood","iraq.baghdad.thalbaa","south");
        System.Console.WriteLine("\nemployee id is "+sm1.EmpID);
        System.Console.WriteLine("employee name is "+sm1.EmpName);
        System.Console.WriteLine("employee location is "+sm1.Location);
        System.Console.WriteLine("the total sales of the month is "  + sm1.GetTotalSalesOfTheMonth());
        
        //creating objects of the ProjectManger class
        ProjectManger pm1 = new ProjectManger(104,"farooq","iraq.baghdad.harthya",2,"lawyer");
        System.Console.WriteLine("\nemployee id is "+pm1.EmpID);
        System.Console.WriteLine("employee name is "+pm1.EmpName);
        System.Console.WriteLine("employee location is "+pm1.Location);
        
        //new interface class
        IPerson person;
            person= new Manger(107, "zaid", "iraq", "media");
            person.DateOfBirth = System.Convert.ToDateTime("2007-10-10");
            System.Console.WriteLine("\n"+ person.GetAge());
        

    }
}