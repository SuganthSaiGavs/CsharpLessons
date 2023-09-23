﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DayFour
{
    class DateDemo
    {
        public static void FirstMethod()
        {
            Console.WriteLine(DateTime.Now);

            DateTime d1 = new DateTime(2018, 04, 10);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToShortDateString());
        }

        public static void SecondMethod()
        {
            Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);
            int year = d1.Year;
            Console.WriteLine("Year OF Dob " + year);
            int month = d1.Month;
            Console.WriteLine("Month OF Dob " + month);
            int day = d1.Day;
            Console.WriteLine("Day OF Dob " + day);
            DateTime d2 = d1.AddMonths(10);
            Console.WriteLine("AddMonths(10) " + d2.ToShortDateString());
            DateTime d3 = d1.AddDays(5);
            Console.WriteLine("AddDays(5) " + d3.ToShortDateString());
            DateTime d4 = d1.AddYears(58);
            Console.WriteLine("AddYears(58) " + d4.ToShortDateString());
            DateTime d5 = d1.AddYears(-5);
            Console.WriteLine("AddYears(-5) " + d5.ToShortDateString());
        }
        #region
        public static void FindAgeOfaPerson()
        {
            Console.WriteLine("Tell me ur DOB (yyyy/mm/dd)?? I will tell ur AGE");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);

            DateTime currentdatetime = DateTime.Now;
            int difference = currentdatetime.Year - d1.Year;
            // Console.WriteLine(difference);

            int dobmonth = d1.Month;
            int dobday = d1.Day;

            if (dobmonth == currentdatetime.Month && dobday == currentdatetime.Day)
            {
                Console.WriteLine(difference);
            }

            else if (currentdatetime.Month < dobmonth )
            {
                Console.WriteLine(difference - 1);
            }
            else if (dobmonth > currentdatetime.Month && dobday > currentdatetime.Day)
            {
                Console.WriteLine(difference);
            }

        }
        #endregion

        /* public static void FindAgeOfaPerson()
         {



             Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
             String strdob = String.Empty;
             try
             {
                 strdob= Console.ReadLine();



                 DateTime D1 = DateTime.Parse(strdob);
                 DateTime D2 = DateTime.Now;



                 TimeSpan ts = D2.Subtract(D1);
                 DateTime age = new DateTime(ts.Ticks);
                /Console.WriteLine(age);
                 Console.WriteLine();



             }
             catch (Exception e)
             {
                 Console.WriteLine(e.Message);
             }

         }*/


        public static void FindAgeOfaPersonBestWay()
        {
            // Prompt the user for their date of birth
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):");
            string dobString = String.Empty;
            try
            {
                dobString = Console.ReadLine();
                if (dobString == null)
                {
                    Console.WriteLine("Date Of Birth is NULL!!!");
                    return;
                }
                // Parse the date of birth
                DateTime dob = DateTime.Parse(dobString);



                // Calculate the age
                DateTime now = DateTime.Now;
                int ageYears = now.Year - dob.Year;
                if (now < dob.AddYears(ageYears))
                {
                    ageYears--;
                }
                int ageMonths = now.Month - dob.Month;
                if (now < dob.AddMonths(ageMonths).AddDays(now.Day - dob.Day))
                {
                    ageMonths--;
                }
                int ageDays = now.Day - dob.Day;
                if (now.Day < dob.Day)
                {
                    ageDays += DateTime.DaysInMonth(now.Year, now.Month);
                }
                // Print the age
                Console.WriteLine(
                    $"You are {ageYears} years, {ageMonths} months, and {ageDays} days old."
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void FindRetirementDate()
        {
            Console.WriteLine("Enter your date of birth (YYYY-MM-DD):, I will tell the retirement date");
            String strdob = Console.ReadLine();
            DateTime d1 = DateTime.Parse(strdob);

            int ReteriementAge = 60;

            int ReteriementYear = d1.Year + ReteriementAge;
            Console.WriteLine(ReteriementYear);


        }

       /* public static void FindRetirementDateCorrect()
        {
          
            
                Console.WriteLine("What is your Date of Birth (yyyy/mm/dd)");
                String strdob = String.Empty;
                try
                {
                    DateTime dob = DateTime.Parse(strdob);
                    DateTime nextMonthDate=dob.AddYears(60).AddMonths(1);
                    DateTime retirementDate= new DateTime(nextMonthDate.Year,nextMonthDate.Month,AddDays(-1);
                    DateTime retirementdate = nextMonthFirstDay.AddDays(-1);
                    Console.WriteLine(retirementdate.ToShortDateString());



                }
                catch (Exception err)
                {
                    Console.WriteLine($"Error:{err.Message}");
                }
            }*/
        

    }

    
}
