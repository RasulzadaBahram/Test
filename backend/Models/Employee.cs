

public class Employee
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Phonenumber { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }



    public virtual void GetInfo() 
    {
        Console.WriteLine($"{Firstname} {Lastname} {Phonenumber} {Address} {Email}");

    }


}

