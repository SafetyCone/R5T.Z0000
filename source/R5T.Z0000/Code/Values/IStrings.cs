using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker
    {
        public string Ampersand => "&";
        public string Asterix => "*";
        public string At => "@";
        public string Backslash => @"\";
        public string CloseBrace => "}";
        public string CloseBracket => "]";
        public string CloseParenthesis => ")";
        public string Colon => ":";
        public string Comma => ",";
        public string CommaSeparatedListSpacedSeparator => ", ";
        public string Dash => "-";
        public string DoubleDot => "..";
        public string DoubleEquals => "==";
        public string DoubleSlash => "//";
        public string DoubleSpaces => "  ";
        public string Ellipsis => "...";
        public string Empty => "";
        public const string Empty_Const = ""; // Constant, as opposed to String.Empty, which is readonly. Only constants can be used as default parameter values.
        public string GreaterThan => ">";
        public string Hash => "#";
        public string LessThan => "<"; // No other name for it: https://english.stackexchange.com/questions/255262/what-is-the-name-of-the-symbols-and
        public string Null => null;
        public string NewLine => this.NewLine_Windows;
        public string NewLine_Windows => "\r\n";
        public string NewLine_NonWindows => "\n";
        public string OpenBrace => "{";
        public string OpenBracket => "[";
        public string OpenParenthesis => "(";
        public string PairedParentheses => "()";
        public string Percent => "%";
        public string Period => ".";
        public const string Period_Const = ".";
        public string Pipe => "|";
        public string PipeSpace => "| ";
        public string QuestionMark => "?";
        public string Space => " ";
        public const string Space_Const = " ";
        public string Slash => "/";
        public string Tab => "\t";
        public string Underscore => "_";

        public string I_UpperCase => "I";

#pragma warning disable IDE1006 // Naming Styles

        public string s_LowerCase => "s";

#pragma warning restore IDE1006 // Naming Styles

        public string NewLineForEnvironment => Environment.NewLine;

        public string No_Lowercase => "no";
        public string No_Camelcase => "No";
        public string No => this.No_Camelcase;
        public string Yes_Lowercase => "yes";
        public string Yes_Camelcase => "Yes";
        public string Yes => this.Yes_Camelcase;
    }
}
