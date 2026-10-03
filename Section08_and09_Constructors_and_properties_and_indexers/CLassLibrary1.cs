public class Employee
{
    //Fields
    private int _empID;
    private string _empName;
    private string _empJob;
    
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
    }

    public Employee(int empId, string empName)
    {
        this._empID = _empID;
        this._empName = empName;
    }

    public Employee()
    {
        
    }

    //static constructors
    static Employee()
    {
            _companyName = "computiq";
    }
    
}