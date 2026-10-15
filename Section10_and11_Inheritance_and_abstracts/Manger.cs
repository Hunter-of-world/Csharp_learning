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
    //method overriding: same name same parameters
    public override string GetHealthInsuranceAmount()
    {
        //if u want to call the parent method use the BASE keyword
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
        return DepartmentName + "at " + base.Location;
    }
}