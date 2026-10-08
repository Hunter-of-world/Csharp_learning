public class Manger:Employee
{
    //fields
    private string _departmentName;
    
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
}