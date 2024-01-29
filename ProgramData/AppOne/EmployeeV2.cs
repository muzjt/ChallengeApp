using System.Diagnostics;

namespace AppOne
{
    internal class EmployeeV2
    {
    }
}

public class EmployeeV2
{

    public EmployeeV2(string name, string idCode)
    {
        this.Name = name;
        this.IdCode = idCode;
    }
    public string Name { get; private set; }
    public string IdCode { get; private set; }

}


