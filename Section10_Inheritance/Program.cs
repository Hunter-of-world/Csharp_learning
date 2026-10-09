class Program
{
    static void Main()
    {
        //create objects of the employee class
        Employee emp1 = new Employee();
        emp1.EmpId = 101;
        emp1.EmpName = "zaid";
        emp1.Location = "iraq.baghdad.zayona";

        //creating objects of the manger class
        Manger mgr1 = new Manger();
        mgr1.EmpId = 100;
        mgr1.EmpName = "muklah";
        mgr1.Location = "iraq.baghdad.karrada";
        mgr1.DepartmentName = "coordination";
        System.Console.WriteLine("the total sales of the year is" + mgr1.GetTotalSalesOfTheYear());

        //creating objects of the salesman class
        SalesMan sm1 = new SalesMan();
        sm1.EmpId = 103;
        sm1.EmpName = "mahmmod";
        sm1.Location = "iraq.baghdad.thalbaa";
        sm1.Region = "south";
        System.Console.WriteLine("the total sales of the month is" + sm1.GetTotalSalesOfTheMonth());
        
        //creating objects of the ProjectManger class
        ProjectManger pm1 = new ProjectManger();
        pm1.EmpId = 104;
        pm1.EmpName = "farooq";
        pm1.Location = "iraq.baghdad.harthya";

    }
}