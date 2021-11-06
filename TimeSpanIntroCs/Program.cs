using System;

namespace TimeSpanIntroCs
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan timeSpan = new TimeSpan(1, 2, 3);

            TimeSpan timeSpan1 = new TimeSpan(1, 0, 0);
            TimeSpan timeSpan2 = TimeSpan.FromHours(1);

            DateTime start = DateTime.Now;
            DateTime end = DateTime.Now.AddMinutes(2);

            TimeSpan duration = end - start;

            Console.WriteLine("Duration: " + duration);

            //Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString" + timeSpan.ToString());

            //Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
