using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_json_from_file
{
    class JsonFile
    {
        public string timestamp { get; set; }
        public Employee[] employees { get; set; }

        public void DisplayInfo()
        {
            foreach (Employee e in employees)
            {
                Console.WriteLine($"ID: {e.id}");
                Console.WriteLine($"Name: {e.name}");
                Console.WriteLine($"E-mail: {e.email}");
                Console.WriteLine($"Birth date: {e.birth_date}");
                Console.WriteLine($"Salary: {e.salary} usd/year");
                Console.WriteLine($"Position: {e.position}");
                Console.WriteLine($"Hired date: {e.hired_date}\n\n");
            }
        }

    }

    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string birth_date { get; set; }
        public int salary { get; set; }
        public string position { get; set; }
        public string hired_date { get; set; }
    }
}
