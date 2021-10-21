using System;

namespace EmployeeWageAIApproach
{
    class Program
    {

        static void Main(string[] args)
        {

            EmpWage.EmpWageCalculation("Vishal", 15, 22, 90);
            EmpWage.EmpWageCalculation("DMart", 18, 22, 86);
            EmpWage.EmpWageCalculation("BigBazaar", 21, 24, 95);
            EmpWage.EmpWageCalculation("Dinzo", 23, 21, 85);
            EmpWage.EmpWageCalculation("Pantaloons", 25, 18, 80);
        }
    }
}