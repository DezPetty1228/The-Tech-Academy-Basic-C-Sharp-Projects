using System;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee CEO;
            CEO.empID = 1234;
            CEO.firstName = "Dezden";
            CEO.lastName = "Petty EL";
            CEO.ssn = "112-23-3445";
            Console.Writeline(CEO);
            Console.Readline();
        }
    }
}
