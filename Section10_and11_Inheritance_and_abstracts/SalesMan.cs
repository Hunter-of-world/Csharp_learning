public class SalesMan:IEmployee
{
    //fields
    private string _region;
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
    public SalesMan(int empID, string empName, string location,string region)
    {
        _region = region;
        this._empName = empName;
        this._empId = empID;
        this._location = location;
    }
    
    //properties
    public string Region
    {
        set
        {
            _region = value;
        }
        get
        {
            return _region;
        }
    }
    //methods
    public long GetTotalSalesOfTheMonth()
    {
        return 1000;
    }
    public  string GetHealthInsuranceAmount()
    {
        return "additonial health insurance Amount is: " + 2000;
    }

}