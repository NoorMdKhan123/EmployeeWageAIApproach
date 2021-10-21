using System;

namespace EmployeeWageAIApproach
{
    class Program
    {

        public const int is_full_time = 1;
        public const int is_part_time = 2;
        public const int emp_rate_per_hour = 20;
        static void Main(string[] args)
        {


            //variable
            int emp_wage = 0;
            int emp_hrs = 0;

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
            Console.WriteLine("Emp Wage is : " + emp_wage);
        }


    }
}
