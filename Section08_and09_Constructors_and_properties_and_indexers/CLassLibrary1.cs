public class Employee
{
    //Fields
    private int _empID;
    private string _empName;
    private string _empJob;
    private double _salary;
    private double _tax;
    
    //instance property
    public int EmpID
    {
        set
        {
            if (value > 100)
            {
                _empID = value;
                
            }
        }
        get
        {
            return _empID;
        }
    }
    public string EmpName
    {
        set
        {
            _empName = value;
        }
        get
        {
            return _empName;
        }
    }
    public string EmpJob
    {
        set
        {
            _empJob= value;
        }
        get
        {
            return _empJob;
        }
    }
    //static Fields
    private static string _companyName;
    //static property 
    public static string CompanyName
    {
        set
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get
        {
            return _companyName;
        }
    }
    //constructors
    public Employee(int empId, string empName, string empJob)
    {
        this._empID = empId;
        this._empName = empName;
        this._empJob = empJob;
        this._salary = 1000;
    }

    public Employee(int empId, string empName)
    {
        this._empID = _empID;
        this._empName = empName;
        this._salary = 1000;

    }

    public Employee()
    {
        this._salary = 1000;

    }

    //static constructors
    static Employee()
    {
            _companyName = "computiq";
    }
    //readonly property
    public double Salary
    {
        get
        {
            return _salary;
        }
    }
    //writeonly property
    public double Tax
    {
        set
        {
            _tax = value;
        }
    }
    //method using a readonly property
    public double CalculatNetSalary()
    {
        double t = Salary - _tax;
        return t;
    }
}