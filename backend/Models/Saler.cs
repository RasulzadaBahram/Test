
public class Saler:Employee
{
    public double Salary { get; set; }
    public double Benefit { get; set; }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"{Salary} {Benefit}");
    }
}

