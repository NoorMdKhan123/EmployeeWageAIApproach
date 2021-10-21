using System;

namespace EmployeeWageAIApproach
{
    class Program
    {


        static void Main(string[] args)
        {
            //constant 
            int is_full_time = 1;
            int is_part_time = 2;
            int emp_rate_per_hour = 20;

            //variable
            int emp_wage = 0;
            int emp_hrs = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == is_full_time)
            {
                emp_hrs = 8;
            }
            else if (empCheck == is_part_time)
            {
                emp_hrs = 4;
            }
            else
            {
                emp_hrs = 0;
            }
            emp_wage = emp_hrs * emp_rate_per_hour;
            Console.WriteLine("Emp Wage is : " + emp_wage);

        }
    }
}
