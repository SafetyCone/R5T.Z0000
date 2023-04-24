using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public partial interface IDateTimes : IValuesMarker
    {
        public DateTime Minimum => DateTime.MinValue;
        public DateTime Maximum => DateTime.MaxValue;
    }
}
