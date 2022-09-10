namespace NextLeapYears
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime thisYear = DateTime.Now;
            int current_year = thisYear.Year;
            int count = 0;

            while (count < 20)
            {
                if (((current_year % 4 == 0) && (current_year % 100 != 0)) || (current_year % 400 == 0))
                {
                    Console.WriteLine(current_year + " is a leap year");
                    count++;
                }
                current_year++;
            }

            Console.ReadLine();
        }
    }
}