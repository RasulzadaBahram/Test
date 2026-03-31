
public class Developer : Employee
{
    public int Projectcount { get; set; }
    public string Speciality { get; set; }


    public override void GetInfo()
    {
        base.GetInfo();
        Console.WriteLine($"{Speciality} {Projectcount}");
    }
}

