namespace AppOne
{
    internal class Employee
    {
    }
}

public class Employee
{

    private List<int> points = new List<int>();

    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;

    }

    public string Name { get; private set; }
    public string Surname { get; private set; }
    public int Age { get; private set; }

    public int sumOfPoints
    {
        get
        {
            return this.points.Sum();
        }
    }

    public void AddPoints(int point)
    {
        this.points.Add(point);
    }

}


