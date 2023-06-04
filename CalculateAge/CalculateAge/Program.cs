namespace CalculateAge
{
    internal class Program
    {
        static void CalcDifference(string Date)
        {
            DateTime nowDate = DateTime.Now;
            string[] lastDate = Date.Split('/');

            int Month = nowDate.Month - Convert.ToInt32(lastDate[1]);

            int Day = DateTime.DaysInMonth(Convert.ToInt32(lastDate[2]), Convert.ToInt32(lastDate[1])) - Convert.ToInt32(lastDate[0]);

            int Year = nowDate.Year;

            if (nowDate.Month >= Convert.ToInt32(lastDate[1]))
            {
                Year -= Convert.ToInt32(lastDate[2]);
            }
            else
            {
                Year -= Convert.ToInt32(lastDate[2]) + 1;
            }
            

            Console.WriteLine($"Person was born {Day} days {Month} months {Year} years ago.");
        }
        
        static void Main()
        {
            CalcDifference("12/04/2003");
        }
    }
}