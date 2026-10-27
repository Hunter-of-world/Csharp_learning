//multi level inheritance
public class ProjectManger:Manger
{
//fields
private int _totalNumberOfProjects;

//constructors
    public ProjectManger (int empID,string empName,string location, int totalNumberOfProjects,string departmentName,string dateOfBirth) : base(empID, empName, location,departmentName,dateOfBirth)    
    {
        _totalNumberOfProjects = totalNumberOfProjects;
    }

//properties
public int TotalNumberOfProjects
{
    set
    {
        _totalNumberOfProjects = value;
    }
    get
    {
        return _totalNumberOfProjects;
    }
}
}