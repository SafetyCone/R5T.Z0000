using System;

using R5T.T0131;


namespace R5T.Z0000
{
    /// <summary>
    /// Names for characters.
    /// Character names start with a lowercase letter, and the words in multi-word names are dash-separated.
    /// </summary>
    [ValuesMarker]
    public interface ICharacterNames : IValuesMarker
    {
        /// <summary>
        /// There is no "unknown" character, this is just the place-holder name for any currently unnamed characters.
        /// </summary>
        public string Unknown => "<unknown>";


        public string CarriageReturn => "carriage-return";
        public string FormFeed => "form-feed";
        public string NextLine => "next-line";
        public string LineFeed => "line-feed";
        public string NonBreakingSpace => "non-breaking-space";
        public string Null => "null";
        public string Space => "space";
        public string StartOfHeading => "start-of-heading";
        public string Tab => "tab";
        public string VerticalTab => "vertical-tab";

        public string Zero => "zero";
        public string One => "one";
        public string Two => "two";
        public string Three => "three";
        public string Four => "four";
        public string Five => "five";
        public string Six => "six";
        public string Seven => "seven";
        public string Eight => "eight";
        public string Nine => "nine";
    }
}
