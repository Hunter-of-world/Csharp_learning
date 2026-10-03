 class Program
 {
     static void Main()
     {
         //create three objects for Employee
         Employee emp1 = new Employee();
         emp1.EmpID = 101;
         emp1.EmpName = "zaid";
         emp1.EmpJob = "trainee";
         emp1.Tax = 50;//since its readonly i cant call it but i can use it in methods
         Employee emp2 = new Employee(102,"abdullah");
         emp2.EmpJob = "trainer";
         Employee emp3 = new Employee(103,"mukalh","manger");
         Employee emp4 = new Employee() { EmpID = 104, EmpName = "zaid", EmpJob = "Ceo" }; //object initializer 
         //display fields
         //first object
         System.Console.WriteLine("company name is "+Employee.CompanyName);
         System.Console.WriteLine("\nEmployee id is "+emp1.EmpID);
         System.Console.WriteLine("Employee name is "+emp1.EmpName);
         System.Console.WriteLine("Employee job is "+emp1.EmpJob);
         System.Console.WriteLine("his salary is "+emp1.Salary);//since its readonly i can change it value
         System.Console.WriteLine("his salary aftet tax it " + emp1.CalculatNetSalary());
         //second object
         System.Console.WriteLine("Employee id is "+emp2.EmpID);
         System.Console.WriteLine("Employee name is "+emp2.EmpName);
         System.Console.WriteLine("Employee job is "+emp2.EmpJob);
         System.Console.WriteLine("his salary is "+emp2.Salary);
         //third object
         System.Console.WriteLine("Employee id is "+emp3.EmpID);
         System.Console.WriteLine("Employee name is "+emp3.EmpName);
         System.Console.WriteLine("Employee job is "+emp3.EmpJob);
         System.Console.WriteLine("his salary is "+emp3.Salary);
         //fourth object
         System.Console.WriteLine("Employee id is "+emp4.EmpID);
         System.Console.WriteLine("Employee name is "+emp4.EmpName);
         System.Console.WriteLine("Employee job is "+emp4.EmpJob);
         System.Console.WriteLine("his salary is "+emp4.Salary);

         

     }
 }