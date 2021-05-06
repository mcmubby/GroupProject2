using System.Globalization;
namespace GroupProject2
{
    public class Holiday
    {
        public string _name;
        public int _day;
        public string _month;

        public Holiday(string name, int day, string month)
        {
            this._name = name;
            this._day = day;
            this._month = month;
        }

        //Default Holiday
        private Holiday()
        {
            this._day = 1;
            this._name = "Independence Day";
            this._month = "October";
        }

        // Compare two objects of this class. Needs to be accessible from the class itself
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
            
            //return average
            double avgDay = daySum / holidays.Length;
            return avgDay;
        }

        public static Holiday NigeriasIndependence()
        {
            return new Holiday();
        }
    }
}