// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Solution to the Employee Class challenge

public class Employee
{
    private static int _employeeCount = 0;
    public int ID { get; init; }
    public required string Department { get; set; }
    public required string FullName { get; set; }
    public static int EmployeeCount { get => _employeeCount; }
    protected static int IDStart { get; set; }
    static Employee()
    {
        IDStart = 1000;
    }
    public Employee() 
    {
        _employeeCount++;
        ID = IDStart++;
    }

    public virtual void AdjustPay(decimal percentage)
    {

    }
    public override string ToString() => $"{ID}:{FullName}, {Department} ";
}

public class HourlyEmployee : Employee
{
    public decimal PayRate { get; set; }
    public override void AdjustPay(decimal percentage)
    {
        PayRate += PayRate * percentage;
    }
}

public class SalariedEmployee : Employee
{
    public decimal Salary { get; set; }
    public override void AdjustPay(decimal percentage)
    {
        Salary += Salary * percentage;
    }
}
