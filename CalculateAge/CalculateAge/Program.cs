namespace CalculateAge
{
    internal class Program
    {
        static void Main()
        {
            CalculateAge();
            Main();
        }
        public static void CalculateAge()
        {
            DateTime dateTime = DateTime.Now;

            DateOnly dateOnly = DateOnly.FromDateTime(dateTime);

            try
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------Welcome to age calculate program------");

                Console.Write("Enter year of birth : ");
                int birthYear = int.Parse(Console.ReadLine());

                Console.Write("Enter month of birth : ");
                int birthMonth = int.Parse(Console.ReadLine());

                Console.Write("Enter day of birth : ");
                int birthDay = int.Parse(Console.ReadLine());

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
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("Please enter valid value.");
                CalculateAge();
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}