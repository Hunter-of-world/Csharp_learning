//multi level inheritance
public class ProjectManger:Manger
{
//fields
private int _totalNumberOfProjects;

//constructors
    public ProjectManger (int empID,string empName,string location, int totalNumberOfProjects,string departmentName) : base(empID, empName, location,departmentName)
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