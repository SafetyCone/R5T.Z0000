using System;


namespace R5T.Z0000
{
    public class DateTimes : IDateTimes
    {
        #region Infrastructure

        public static IDateTimes Instance { get; } = new DateTimes();


        private DateTimes()
        {
        }

        #endregion
    }
}
