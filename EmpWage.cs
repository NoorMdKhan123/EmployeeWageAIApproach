using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageAIApproach
{
    class EmpWage
    {
        //constant
        const int is_full_time = 1;
        const int is_part_time = 2;

        public static int EmpWageCalculation(string company, int emp_rate_per_hour,

            int max_working_days, int max_working_hours)
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
                Console.WriteLine("Emp Wage for Company : " + company + " is " + emp_wage);
            }
            Console.WriteLine("Emp Wage for whole month  for  : " + company +
                " is : " + total_emp_wage +
                " total emp hrs " + total_emp_hrs);
            return total_emp_hrs;
        }


    }
}