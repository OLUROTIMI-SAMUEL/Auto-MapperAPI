using System;

namespace AutoMaper_API.HelperFunction
{
    public static class HelperFunction
    {
        public static int GetCurrentAge(this DateTimeOffset dateTimeOffSet )
        {
            var currentDate = DateTime.UtcNow;
            int age =currentDate.Year - dateTimeOffSet.Year;

            if (currentDate < dateTimeOffSet.AddYears(age))
            {
                age--;
            }
            return age;
        }

    }
}
//so the helper function here takes the date to give us the age 
