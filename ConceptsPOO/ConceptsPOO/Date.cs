namespace ConceptsPOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        //Contructor
        // ctor es el sniper para construir constructor con doble tab
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        // Metodo del dia
        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            }

            // Arreglo 
            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid day");
        }

        //Metodo año bisiesto
        private bool IsleapYear(int year)
        {

            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0 )
            //    {

            //        if (year % 400 == 0)
            //        {

            //            return true;
            //        }
            //        else
            //        { 
            //          return false;
            //        }

            //    }
            //    else
            //    { 
            //        return true;
            //    }

            //}
            //else
            //{ 
            //    return false;
            //}

            throw new NotImplementedException();
        }

        //metodo del mes
        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("Invalid Month");
        }

        // sobreescribir  el ToString()
        public override string ToString()
        {
            // interpobacion de ToString()
            return $"{_year}/{_month:00}/{_day:00}";
        }

    }
}
