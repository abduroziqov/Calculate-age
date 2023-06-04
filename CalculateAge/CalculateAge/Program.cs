using System;
using System.Runtime.CompilerServices;

namespace CalculateAge
{
    internal class Program
    {
        static void Main()
        {
            bool progress = true;
            
            while (progress)
            {
                CalculateAge();
                progress = Answer();
            }
        }

        public static bool Answer()
        {
            bool result = true;
            
            Console.WriteLine("Do you have a continue? (yes, no)");
            
            while(result)
            {
                string? answer = Console.ReadLine();
                if(answer == "no")
                {
                    Console.Clear();
                    result = false;
                }
                else if (answer == "yes")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect syntax, try again...");
                }
            }
            return result;
        }
        public static void CalculateAge()
        {
            DateOnly nowDate = DateOnly.FromDateTime(DateTime.Now);

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------Welcome to age calculate program------");

                #region Receive Values From User
                Console.Write("Enter year of birth : ");
                int birthYear = int.Parse(Console.ReadLine());

                Console.Write("Enter month of birth : ");
                int birthMonth = int.Parse(Console.ReadLine());

                Console.Write("Enter day of birth : ");
                int birthDay = int.Parse(Console.ReadLine());
                #endregion

                #region Calculates Values To Human Readable Format
                DateOnly.TryParse($"{birthMonth}/{birthDay}/{birthYear}", out DateOnly lastDate);

                int calculateYear = nowDate.Year - lastDate.Year;
                
                int calculateMonth = (nowDate.Month < lastDate.Month) ? 
                                     (nowDate.Month + 12) - lastDate.Month : 
                                     calculateMonth = nowDate.Month - lastDate.Month;
                

                int calculateDay = (nowDate.Day < lastDate.Day) ? 
                                   DateTime.DaysInMonth(nowDate.Year, nowDate.Month) - lastDate.Day :
                                   nowDate.Day - lastDate.Day;

                Console.WriteLine($"The person was born {calculateMonth} months {calculateDay} days {calculateYear} years ago.\n");
                #endregion
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter valid value...");
                CalculateAge();
            }
        }
    }
}