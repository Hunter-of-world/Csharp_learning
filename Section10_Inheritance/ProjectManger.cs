//multi level inheritance
public class ProjectManger:Manger
{
//fields
private int _totalNumberOfProjects;

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