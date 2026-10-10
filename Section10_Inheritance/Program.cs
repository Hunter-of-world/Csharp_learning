class Program
{
    static void Main()
    {
        //create objects of the employee class
        Employee emp1 = new Employee(101,"zaid","iraq.baghdad.zayona");

        //creating objects of the manger class
        Manger mgr1 = new Manger(100,"muklah","iraq.baghdad.karrada","coordination");
      
        System.Console.WriteLine("the total sales of the year is " + mgr1.GetTotalSalesOfTheYear());
        System.Console.WriteLine("he is "+mgr1.GetFullDepartmentName());

        //creating objects of the salesman class
        SalesMan sm1 = new SalesMan(103,"mahmood","iraq.baghdad.thalbaa","south");
        System.Console.WriteLine("the total sales of the month is "  + sm1.GetTotalSalesOfTheMonth());
        
        //creating objects of the ProjectManger class
        ProjectManger pm1 = new ProjectManger(104,"farooq","iraq.baghdad.harthya",2,"lawyer");
        
    }
}