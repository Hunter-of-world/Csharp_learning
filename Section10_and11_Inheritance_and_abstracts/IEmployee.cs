public  interface IEmployee:IPerson
{
    
    //abstract method
    public abstract string GetHealthInsuranceAmount();
    //properties
    public int EmpID
    {
        get;
        set;
    }

    public string EmpName
    {
        get;
        set;
    }

    public string Location
    {
        get;
        set;
    }
}