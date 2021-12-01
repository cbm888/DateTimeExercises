using System;

namespace datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = new DateTime();

            today = DateTime.Now;

            var yesterday = today.AddDays(-1);
            Console.WriteLine(yesterday);


            Console.WriteLine(today.ToLongDateString());
            Console.WriteLine(today.ToShortDateString());

            Console.WriteLine(today.ToLongTimeString());
            Console.WriteLine(today.ToShortTimeString());
        }

        public void dateTime()
        {
            var timeSpan = new TimeSpan(1, 2, 3);
            

            TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
        }

    }
}
