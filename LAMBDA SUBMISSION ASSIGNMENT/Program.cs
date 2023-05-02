using System;
using System.Collections.Generic;

namespace LAMBDA_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> staff = new List<Employee>();
            //  In the Main() method, create a list of at least 10 employees. At least two employees should have the first name “Joe”.


            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            Employee employee4 = new Employee();
            Employee employee5 = new Employee();
            Employee employee6 = new Employee();
            Employee employee7 = new Employee();
            Employee employee8 = new Employee();
            Employee employee9 = new Employee();
            Employee employee10 = new Employee();

            employee1.ID = 1111;
            employee1.FirstName = "Joe";
            employee1.LastName = "Carter";

            employee2.ID = 1112;
            employee2.FirstName = "Steve";
            employee2.LastName = "Baker";

            employee3.ID = 1113;
            employee3.FirstName = "Tommy";
            employee3.LastName = "Jones";

            employee4.ID = 1114;
            employee4.FirstName = "Joe";
            employee4.LastName = "Smith";

            employee5.ID = 1115;
            employee5.FirstName = "Teyonna";
            employee5.LastName = "Trump";

            employee6.ID = 1116;
            employee6.FirstName = "David";
            employee6.LastName = "Evans";

            employee7.ID = 1117;
            employee7.FirstName = "Ray";
            employee7.LastName = "Lewis";

            employee8.ID = 1118;
            employee8.FirstName = "Tommy";
            employee8.LastName = "Spinks";

            employee9.ID = 1119;
            employee9.FirstName = "Joe";
            employee9.LastName = "Lewis";

            employee10.ID = 1120;
            employee10.FirstName = "Kenny";
            employee10.LastName = "Bell";

            staff.Add(employee1);
            staff.Add(employee2);
            staff.Add(employee3);
            staff.Add(employee4); 
            staff.Add(employee5);
            staff.Add(employee6);
            staff.Add(employee7);
            staff.Add(employee8);
            staff.Add(employee9);
            staff.Add(employee10);

            List<Employee> joeList = new List<Employee>();

            //  Using a foreach loop, create a new list of all employees with the first name “Joe”. In your comparison statement, remember to reference the property of the object you are checking.

            foreach (Employee employee in staff)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList.Add(employee);
                }

            }

            //  Perform the same action again, but this time with a lambda expression.

            List<Employee> joeList2 = staff.FindAll(x => (x.FirstName == "Joe"));
            foreach (Employee employee in joeList2)
            {
                Console.WriteLine(employee.FirstName);
            }
            // Using a lambda expression, make a list of all employees with an Id number greater than 5.

            List<Employee> joeList3 = staff.FindAll(x => (x.ID > 5));
            Console.ReadLine();
        }
    }
}
