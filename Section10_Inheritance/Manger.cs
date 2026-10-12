public class Manger:Employee
{
    //fields
    private string _departmentName;
    
    //constructors
    public Manger(int empId, string empName, string location ,string departmentName): base(empId,empName,location)
    {
        _departmentName = departmentName;

    }
    
    //methods
    //method hiding: same name same parameters but the return type can be different
    public new string GetHealthInsuranceAmount()
    {
        return "health insurance Amount is: " + 1500;
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
        return DepartmentName + "at " + base.Location;
    }
}