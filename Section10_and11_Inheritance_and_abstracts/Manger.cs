public class Manger:IEmployee,IPerson
{
    //fields
    private string _departmentName;
    private string _empName;
    private string _location;
    private int _empId;
    private System.DateTime _dateOfBirth;

    public System.DateTime DateOfBirth
    {
        set
        {
            _dateOfBirth = value;
        }
        get
        {
            return _dateOfBirth;
        }
    }
    public int EmpID
    {
        get
        {
            return _empId;
        }
        set
        {
            _empId = value;
        }
    }

    public string EmpName
    {
        get
        {
            return _empName;
        }
        set
        {
            _empName = value;
        }
    }

    public string Location
    {
        get
        {
            return _location;
        }
        set
        {
            _location = value;
        }
    }
    
    //constructors
    public Manger(int empID, string empName, string location, string departmentName)
    {
        _departmentName = departmentName;
        this._empName = empName;
        this._empId = empID;
        this._location = location;

    }
    
    //methods
    //method overriding abstract method not required for interface
    public string GetHealthInsuranceAmount()
    {
        return "additonial health insurance Amount is: " + 1500;
    }

    public int GetAge()
    {
        int age =System.Convert.ToInt32((System.DateTime.Now - DateOfBirth).TotalDays / 365);
        return age;
    }

    //properties
    public string DepartmentName
    {
        set
        {
            _departmentName = value;
        }
        get
        {
            return _departmentName;
        }
    }

    
    

    public long GetTotalSalesOfTheYear()
    {
        return 10000;
    }

    public string GetFullDepartmentName()
    {
        return DepartmentName + "at " + Location;
    }
}