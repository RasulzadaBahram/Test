public class Manager : Employee
{
    public double Salary { get; set; }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"{Salary}");
    }
}

