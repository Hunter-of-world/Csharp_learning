public class SalesMan:Employee
{
    //fields
    private string _region;
    
    //constructors
    public SalesMan(int empID, string empName, string location,string region) : base(empID, empName, location)
    {
        _region = region;
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

}