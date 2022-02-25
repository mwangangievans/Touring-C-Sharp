using System;
using System.Collections.Generic;

namespace Demo2
{

    delegate bool IsPromotable(Employee empl);
    class Program
    {
        //deligates are used to make class re-usable

        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee() { ID = 1, Name = "evans", Salary = 2000, Experience = 5 });
            empList.Add(new Employee() { ID = 2, Name = "Mary", Salary = 10000, Experience = 3 });
            empList.Add(new Employee() { ID = 3, Name = "Ken", Salary = 3400, Experience = 4 });
            empList.Add(new Employee() { ID = 1, Name = "Jemmy", Salary = 8752, Experience = 10 });
            empList.Add(new Employee() { ID = 1, Name = "martin", Salary = 3459, Experience = 6 });

            IsPromotable isPromotable = new IsPromotable(Promote);

            Employee.PromoteEmployee(empList, isPromotable);
        }


        public static bool Promote(Employee empl)
        {
            if (empl.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }
        public static void PromoteEmployee(List<Employee> employeeList, IsPromotable del)
        {
            foreach (Employee employee in employeeList)
            {
                if (del(employee))
                {
                    Console.WriteLine("" + employee.Name + " promoted");
                }

            }
        }


    }
}
