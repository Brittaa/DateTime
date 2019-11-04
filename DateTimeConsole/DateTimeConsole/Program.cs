using System;

namespace DateTimeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var dateToday = new DateTime(1991,5,22);
            Console.WriteLine(dateToday);
            var dayOfTheWeek = dateToday.DayOfWeek;
            Console.WriteLine(dayOfTheWeek);*/


            /*Console.WriteLine("Please enter your birthdate(YYYY/MM/DD): ");
            string userData = Console.ReadLine();

            string[] personalData = userData.Split('/');
            int year = int.Parse(personalData[0]);
            int month = int.Parse(personalData[1]);
            int day = int.Parse(personalData[2]);

            var userBirthday = new DateTime(year, month, day);
            var birtdayDayOfTheWeek = userBirthday.DayOfWeek;

            Console.WriteLine($"You are born on {birtdayDayOfTheWeek}.");*/

            var dateObject = new DateTime(2019,11,1);
            var currentDate = DateTime.Now;
            Console.WriteLine(currentDate);

            var currentDayOfTheWeek = currentDate.DayOfWeek;
            Console.WriteLine(currentDayOfTheWeek);

            var ticks = dateObject.Ticks;//second since Jan 1, 1970
            Console.WriteLine($"Ticks {ticks}");
            Console.WriteLine($"Print current date: {currentDate}");
            Console.WriteLine($"Print long date string: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Print short date string: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Print long time string: {currentDate.ToLongTimeString()}");
            Console.WriteLine($"Print short time string: {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Date format: {currentDate.ToString("dd-MM-yyyy hh:mm")}");




        }
    }
}
