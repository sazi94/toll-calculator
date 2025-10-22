using Nager.Date;


namespace TollFeeCalculator
{
    public class DateHandler
    {
        
        public static bool IsPublicHoliday(DateTime date)
        {
            
            var holidays = HolidaySystem.GetHolidays(date.Year, CountryCode.SE);
            return holidays.Any(holiday => holiday.Date.Date == date.Date);
        }

    }
}