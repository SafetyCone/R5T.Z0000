using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public interface ICharacterIndexes : IValuesMarker
    {
        /// <summary>
        /// The default first index is zero (0).
        /// </summary>
        public int Default_FirstIndex => 0;
        /// <summary>
        /// The default last ASCII index is 255 (covering 2 ^ 8 = 256 values from 0 to 255, inclusive).
        /// </summary>
        public int ASCII_LastIndex => 255;
        /// <summary>
        /// The default last, unextended, ASCII index is 127 (covering 2 ^ 7 = 128 values from 0 to 127, inclusive).
        /// </summary>
        public int ASCII_Unextended_LastIndex => 127;
    }
}
