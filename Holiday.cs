using System.Globalization;
namespace GroupProject2
{
    public class Holiday
    {
        public string _name { get; private set; }
        public int _day { get; private set; }
        public string _month { get; private set; }

        public Holiday(string name, int day, string month)
        {
            this._name = name;
            this._day = day;
            this._month = month;
        }

        public static bool inSameMonth(Holiday firstHoliday, Holiday secondHoliday)
        {
            return firstHoliday._month.ToLower() == secondHoliday._month.ToLower() ? true : false;
        }

        public static double avgDate(Holiday[] holidays)
        {
            double daySum = 0.00d;
            foreach (var holiday in holidays)
            {
               daySum += holiday._day;
            }
            
            double avgDay = daySum / holidays.Length;
            return avgDay;
        }

        public static Holiday NigeriasIndependence()
        {
            return new Holiday("Independence Day", 1, "October");
        }
    }
}