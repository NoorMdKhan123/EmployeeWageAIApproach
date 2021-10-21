using System;

namespace EmployeeWageAIApproach
{
    class Program
    {

        //constant
        public const int is_full_time = 1;
        public const int is_part_time = 2;
        public const int emp_rate_per_hour = 20;
        public const int max_working_days = 20;
        public const int max_working_hours = 100;
        static void Main(string[] args)
        {


            //variable
            int emp_wage = 0;
            int emp_hrs = 0;
            int total_emp_hrs = 0;
            int total_emp_wage = 0;
            int total_woking_days = 0;


            while (total_woking_days < max_working_days && emp_hrs <= max_working_hours)
            {
                total_woking_days++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case is_full_time:

                        emp_hrs = 8;
                        break;


                    case is_part_time:

                        emp_hrs = 4;
                        break;


                    default:
                        emp_hrs = 0;
                        break;
                }

                emp_wage = emp_hrs * emp_rate_per_hour;
                total_emp_wage += emp_wage;
                total_emp_hrs += emp_hrs;
                Console.WriteLine("Emp Wage for day " + total_woking_days + " is " + emp_wage);
            }
            Console.WriteLine("Emp Wage for whole month is : " + total_emp_wage +
                " total emp hrs " + total_emp_hrs);
        }
    }
}