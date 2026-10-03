 class Program
 {
     static void Main()
     {
         //create three objects for Employee
         Employee emp1 = new Employee();
         emp1.empID = 101;
         emp1.empName = "zaid";
         emp1.empJob = "trainee";
         Employee emp2 = new Employee(102,"abdullah");
         emp2.empJob = "trainer";
         Employee emp3 = new Employee(103,"mukalh","manger");
         //display fields
         //first object
         System.Console.WriteLine("company name is "+Employee.companyName);
         System.Console.WriteLine("\nEmployee id is "+emp1.empID);
         System.Console.WriteLine("Employee name is "+emp1.empName);
         System.Console.WriteLine("Employee job is "+emp1.empJob);
         //second object
         System.Console.WriteLine("Employee id is "+emp2.empID);
         System.Console.WriteLine("Employee name is "+emp2.empName);
         System.Console.WriteLine("Employee job is "+emp2.empJob);
         //third object
         System.Console.WriteLine("Employee id is "+emp3.empID);
         System.Console.WriteLine("Employee name is "+emp3.empName);
         System.Console.WriteLine("Employee job is "+emp3.empJob);


         

     }
 }