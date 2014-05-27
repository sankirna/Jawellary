using System;

namespace MobileSurvey.Utils.Utilities
{
    public static class DateUtil
    {
        /// <summary>
        /// Get Current Date
        /// </summary>
        /// <returns></returns>
        public static DateTime GetCurrentDateTime()
        {
            try
            {
                return DateTime.Now;
            }
            catch (Exception ex)
            {
                ex.LogError(typeof(DateUtil));
            }
            return new DateTime();
        }
    }
}
