
public class SMM_Manager:Employee
{
    public int WorkHours { get; set; }

    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"{WorkHours}");
    }
}
