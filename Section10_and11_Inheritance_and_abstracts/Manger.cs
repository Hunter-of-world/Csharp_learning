public class Manger:IEmployee
{
    //fields
    private string _departmentName;
    private string _empName;
    private string _location;
    private int _empId;
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