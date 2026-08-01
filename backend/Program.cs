
public class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new();

        //Employee employee1 = new Employee()
        //{
        //    Id = 2,
        //    Firstname = "Be",
        //    Lastname = "Hram",
        //    Address = "Mir",
        //    Email = "123@gmail.com",
        //    Phonenumber = "+994551157623"
        //};
        //Employee employee2 = new Employee()
        //{
        //    Id = 3,
        //    Firstname = "Be",
        //    Lastname = "Hram",
        //    Address = "Mir",
        //    Email = "123@gmail.com",
        //    Phonenumber = "+994551157623"
        //};


        Developer developer = new Developer()
        {
            Projectcount = 5,
            Speciality = "Backend"
        };

        Developer developer1 = new Developer()
        {
            Projectcount = 3,
            Speciality = "Frontend"
        };

        Developer developer2 = new Developer()
        {
            Projectcount = 5,
            Speciality = "Backend"
        };

        Manager manager = new Manager()
        {
            Salary = 1415.1d
        };
        Manager manager1 = new Manager()
        {
            Salary = 143.8d
        };

        SMM_Manager smm_manager = new SMM_Manager()
        {
            WorkHours = 5
        };
        SMM_Manager smm_manager1 = new SMM_Manager()
        {
            WorkHours = 5
        };

        Saler saler = new Saler()
        {
            Salary = 1451d,
            Benefit = 15.2d
        };
        Saler saler1 = new Saler()
        {
            Salary = 1414d,
            Benefit = 15.2d
        };
        Saler saler2 = new Saler()
        {
            Salary = 1441d,
            Benefit = 35.2d
        };
        Saler saler3 = new Saler()
        {
            Salary = 14512d,
            Benefit = 25.2d
        };
        Saler saler4 = new Saler()
        {
            Salary = 1415d,
            Benefit = 14.2d
        };
        Saler saler5 = new Saler()
        {
            Salary = 1231d,
            Benefit = 54.2d
        };

        employees.Add(developer);
        employees.Add(developer1);
        employees.Add(developer2);
        employees.Add(manager);
        employees.Add(manager1);
        employees.Add(smm_manager);
        employees.Add(smm_manager1);
        employees.Add(saler);
        employees.Add(saler1);
        employees.Add(saler2);
        employees.Add(saler3);
        employees.Add(saler4);
        employees.Add(saler5);

        foreach (var item in employees)
        {
            if (item is Saler)
            {
                Saler _saler = (Saler)item;
                _saler.Salary = _saler.Salary * 1.1;
                _saler.GetInfo();
            }
            smm_manager1.WorkHours = smm_manager1.WorkHours - 3;
            if (item is Developer)
            {
                Developer _developer = (Developer)item;
                _developer.Projectcount = _developer.Projectcount + 2;
                _developer.GetInfo();
            }
            if (item is Manager)
            {
                Manager _manager = (Manager)item;
                _manager.Salary = _manager.Salary * 1.3;
                _manager.GetInfo();
            }
        }





    }
}

