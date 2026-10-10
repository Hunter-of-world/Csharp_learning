public class Employee
{
    //fields
    private int _empID;
    private string _empName;
    private string _location;
    
    //constructors 
    public Employee(int empId, string empName, string location)
    {
        this._empID = empId;
        this._location = location;
        this._empName = empName;

    }
    
    //properties
    public int EmpId
    {
        set
        {
            _empID = value;
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

    public string Location
    {
        set
        {
            _location = value;
        }
        get
        {
            return _location;
        }
        
        
    }
}