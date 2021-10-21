using System;

namespace EmployeeWageAIApproach
{
    class Program
    {
        
        
            static void Main(string[] args)
            {
                int employee_is_present = 1;

                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == employee_is_present)
                    Console.WriteLine("Employee is Present");
                else
                {
                    Console.WriteLine("employee is absent");
                }
            }
        
    }
}
