using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// The default number of spaces in a tab is four (4).
        /// </summary>
        public const int DefaultTabSpacesCount_Const = 4;

        /// <inheritdoc cref="DefaultTabSpacesCount_Const"/>
        public int DefaultTabSpacesCount => IValues.DefaultTabSpacesCount_Const;
    }
}
