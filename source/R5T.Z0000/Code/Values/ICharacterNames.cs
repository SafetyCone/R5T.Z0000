using System;

using R5T.T0131;


namespace R5T.Z0000
{
    /// <summary>
    /// Names for characters.
    /// Character name values all:
    /// * start with a lowercase letter,
    /// * words in multi-word names are dash-separated
    /// Sources:
    /// * <see href="https://www.ascii-code.com/"/>
    /// </summary>
    [ValuesMarker]
    public interface ICharacterNames : IValuesMarker
    {
        /// <summary>
        /// There is no "unknown" character, this is just the place-holder name for any currently unnamed characters.
        /// </summary>
        public string Unknown => "<unknown>";

        public string Acknowledgment => "acknowledgment";
        public string Ampersand => "ampersand";
        public string Asterix => "asterisk";
        public string At => "at";
        public string Backslash => "backslash";
        public string Backspace => "backspace";
        public string Backtick => "backtick";
        public string Bell => "bell";
        public string Cancel => "cancel";
        public string Caret => "caret";
        public string CarriageReturn => "carriage-return";
        public string CloseBrace => "close-brace";
        public string CloseBracket => "close-bracket";
        public string CloseParenthesis => "close-parenthesis";
        public string Colon => "colon";
        public string Comma => "comma";
        public string DataLineEscape => "data-line-escape";
        public string Delete => "delete";
        public string DeviceControl1 => "device-control-1";
        public string DeviceControl2 => "device-control-2";
        public string DeviceControl3 => "device-control-3";
        public string DeviceControl4 => "device-control-4";
        public string Dollar => "dollar";
        public string DoubleQuote => "double-quote";
        public string Equals => "equals";
        public string EndOfMedium => "end-of-medium";
        public string EndOfText => "end-of-text";
        public string EndOfTransmission => "end-of-transmission";
        public string EndOfTransmitBlock => "end-of-transmit-block";
        public string Enquiry => "enquiry";
        public string Escape => "escape";
        public string ExclamationMark => "exclamation-mark";
        public string FileSeparator => "file-separator";
        public string FormFeed => "form-feed";
        public string GreaterThan => "greater-than";
        public string GroupSeparator => "group-separator";
        public string HorizontalTab => "horizontal-tab";
        public string Hyphen => "hyphen";
        public string NextLine => "next-line";
        public string LessThan => "less-than";
        public string LineFeed => "line-feed";
        public string NegativeAcknowledgment => "negative-acknowledgment";
        public string NonBreakingSpace => "non-breaking-space";
        public string Null => "null";
        public string OpenBrace => "open-brace";
        public string OpenBracket => "open-bracket";
        public string OpenParenthesis => "open-parenthesis";
        public string Percent => "percent";
        public string Period => "period";
        public string Pipe => "pipe";
        public string Plus => "plus";
        public string Pound => "pound";
        public string QuestionMark => "question-mark";
        public string RecordSeparator => "record-separator";
        public string Semicolon => "semi-colon";
        public string ShiftIn => "shift-in";
        public string ShiftOut => "shift-out";
        public string Slash => "slash";
        public string SingleQuote => "single-quote";
        public string Space => "space";
        public string StartOfHeading => "start-of-heading";
        public string StartOfText => "start-of-text";
        public string Substitute => "substitute";
        public string SynchronousIdle => "synchronous-idle";
        public string Tab => "tab";
        public string Tilde => "tilde";
        public string Underscore => "underscore";
        public string UnitSeparator => "unit-separator";
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
