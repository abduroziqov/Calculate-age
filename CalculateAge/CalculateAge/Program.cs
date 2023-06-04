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
            DateTime dateTime = DateTime.Now;

            DateOnly dateOnly = DateOnly.FromDateTime(dateTime);

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------Welcome to age calculate program------");

                #region Receive Values From User
                Console.Write("Enter year of birth : ");
                int.TryParse(Console.ReadLine(), out int birthYear);

                Console.Write("Enter month of birth : ");
                int.TryParse(Console.ReadLine(), out int birthMonth);

                Console.Write("Enter day of birth : ");
                int.TryParse(Console.ReadLine(), out int birthDay);
                #endregion

                #region Calculates Values To Human Readable Format
                int calculateYear = dateOnly.Year - birthYear;

                int calculateMonth = dateOnly.Month - birthMonth;

                if (birthDay < dateOnly.Day)
                {
                    int calculateDay = (dateOnly.Day) - birthDay;

                    Console.WriteLine($"The person was born {calculateMonth} months {calculateDay} days {calculateYear} years ago.\n");
                }
                else
                {
                    int calculateDay = (dateOnly.Day + 30) - birthDay;
                    Console.WriteLine($"The person was born {calculateMonth} months {calculateDay} days {calculateYear} years ago.\n");
                }
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