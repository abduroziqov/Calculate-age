namespace CalculateAge
{
    internal class Program
    {
        static void CalcDifference(string Date)
        {
            if (DateTime.TryParse(Date, out DateTime parsed_date))
            {
                int diff_years = DateTime.Now.Year - parsed_date.Year;
                int diff_months = DateTime.Now.Month - parsed_date.AddYears(-diff_years).Month;
                int diff_days = DateTime.Now.Day - parsed_date.AddYears(-diff_years).AddMonths(-diff_months).Day;

                Console.WriteLine($"Person was born {diff_days} days {diff_months} months {diff_years} years ago.");
            }
        }

        static void Main()
        {
            CalcDifference("04/06/2003");
        }
    }
}