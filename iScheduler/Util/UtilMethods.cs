using System;

namespace iScheduler.WEB.Util
{
    public static class UtilMethods
    {
        public static bool IsInRange(this DateTime date, DateTime? dateArg1, DateTime? dateArg2)
        {
            if (dateArg1 == null || dateArg2 == null)
                return false;

            if (date.CompareTo(dateArg1) == -1 && date.CompareTo(dateArg2) == 1)
                return true;

            if (date.CompareTo(dateArg1) == 1 && date.CompareTo(dateArg2) == -1)
                return true;

            return false;
        }
    }
}