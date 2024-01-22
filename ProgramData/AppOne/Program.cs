using AppOne;

Employee employee1 = new Employee("Anton", "Chigurh", 38);
Employee employee2 = new Employee("Llewelyn", "Moss", 37);
Employee employee3 = new Employee("Hans", "Landa", 43);

Random rnd1 = new Random();
Random rnd2 = new Random();
Random rnd3 = new Random();

for (int i = 0; i < 5; i++)
{
    employee1.AddPoints(rnd1.Next(1, 11));
    employee2.AddPoints(rnd2.Next(1, 11));
    employee3.AddPoints(rnd3.Next(1, 11));
}

for (int i = 0; i > -1; i--)
{
    employee1.AddPoints(rnd1.Next(1, 11));
    employee2.AddPoints(rnd2.Next(1, 11));
    employee3.AddPoints(rnd3.Next(1, 11));
}

if (employee1.sumOfPoints > employee2.sumOfPoints && employee1.sumOfPoints > employee3.sumOfPoints)
{
    Console.WriteLine($"Employee data:\n\n{employee1.Name}\t{employee1.Surname}\t\tage:\t{employee1.Age}\nPoints\tearned:\t{employee1.sumOfPoints}");
}
else if (employee2.sumOfPoints > employee1.sumOfPoints && employee2.sumOfPoints > employee3.sumOfPoints)
{
    Console.WriteLine($"Employee data:\n\n{employee2.Name}\t{employee2.Surname}\t\tage:\t{employee2.Age}\nPoints\tearned:\t{employee2.sumOfPoints}");
}
else if (employee3.sumOfPoints > employee1.sumOfPoints && employee3.sumOfPoints > employee2.sumOfPoints)
{
    Console.WriteLine($"Employee data:\n\n{employee3.Name}\t{employee3.Surname}\t\tage:\t{employee3.Age}\nPoints\tearned:\t{employee3.sumOfPoints}");
};
