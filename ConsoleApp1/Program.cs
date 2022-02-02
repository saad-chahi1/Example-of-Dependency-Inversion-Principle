using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emps = new List<Employee>()
            {
                new Employee()
                {
                    Name = "Saad",
                    Gender = Gender.Male,
                    Position = Position.Manager
                },
                new Employee()
                {
                    Name = "Mohammed",
                    Gender = Gender.Male,
                    Position = Position.Manager
                },
                new Employee()
                {
                    Name = "Aziza",
                    Gender = Gender.Female,
                    Position = Position.Administrator
                }
            };
            
            EmployeeManager em = new EmployeeManager();
            em.AddListEmployees(emps);

            EmployeeStatistics es= new EmployeeStatistics(em);
            Console.WriteLine(es.CountFemaleManagers);

            Console.ReadKey();
        }
    }
}
