public class SalesMan:Employee
{
    //fields
    private string _region;
    
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