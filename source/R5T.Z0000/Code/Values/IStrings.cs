using System;

using R5T.T0131;


namespace R5T.Z0000
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker
    {
        public string Ampersand => "&";
        public string Apostrophe => "'";
        public string Asterix => "*";
        public string At => "@";
        public string Backslash => @"\";
        /// <inheritdoc cref="ICharacters.CloseAngleBracket"/>
        public string CloseAngleBracket => ">";
        public string CloseBrace => "}";
        public string CloseBracket => "]";
        /// <inheritdoc cref="ICharacters.CloseParenthesis"/>
        public string CloseParenthesis => ")";
        public string Colon => ":";
        /// <inheritdoc cref="ICharacters.Comma"/>
        public string Comma => ",";
        public string CommaSeparatedListSpacedSeparator => ", ";
        public string Dash => "-";
        public string DoubleDot => "..";
        public string DoubleEquals => "==";
        public string DoubleQuote => this.Quote;
        public string DoubleSlash => "//";
        public string DoubleSpaces => "  ";
        public string Ellipsis => "...";
        public string Empty => "";
        public const string Empty_Const = ""; // Constant, as opposed to String.Empty, which is readonly. Only constants can be used as default parameter values.
        public string GreaterThan => ">";
        public string Hash => "#";
        public string LessThan => "<"; // No other name for it: https://english.stackexchange.com/questions/255262/what-is-the-name-of-the-symbols-and
        public string Null => IStrings.Null_Constant;
        public const string Null_Constant = null;
        public string Null_StandardRepresentation => "null";
        public string Null_TextRepresentation => "<null>";
        public string NewLine => this.NewLine_Windows;
        public string NewLine_Windows => "\r\n";
        public string NewLine_NonWindows => "\n";
        /// <inheritdoc cref="ICharacters.OpenAngleBracket"/>
        public string OpenAngleBracket => "<";
        public string OpenBrace => "{";
        public string OpenBracket => "[";
        /// <inheritdoc cref="ICharacters.OpenParenthesis"/>
        public string OpenParenthesis => "(";
        public string PairedParentheses => "()";
        public string Percent => "%";
        /// <inheritdoc cref="ICharacters.Period"/>
        public string Period => ".";
        public const string Period_Const = ".";
        public string Pipe => "|";
        public string PipeSpace => "| ";
        public string QuestionMark => "?";
        /// <inheritdoc cref="ICharacters.Quote"/>
        public string Quote => "\"";
        public string Semicolon => ";";
        public string SingleQuote => this.Apostrophe;
        /// <inheritdoc cref="ICharacters.Space"/>
        public string Space => " ";
        public const string Space_Const = " ";
        /// <inheritdoc cref="ICharacters.Slash"/>
        public string Slash => IStrings.Slash_Constant;
        /// <inheritdoc cref="ICharacters.Slash"/>
        public const string Slash_Constant = "/";
        public string Tab => "\t";
        public string Underscore => "_";

        public string A_Uppercase => "A";
        public string I_Uppercase => "I";

#pragma warning disable IDE1006 // Naming Styles

        public string s_Lowercase => "s";

#pragma warning restore IDE1006 // Naming Styles

        public string NewLine_ForEnvironment => Environment.NewLine;

        public string No_Lowercase => "no";
        public string No_PascalCase => "No";
        public string No_UpperCase => "NO";
        /// <summary>
        /// Chooses <see cref="No_PascalCase"/> as the default.
        /// </summary>
        public string No => this.No_PascalCase;
        public string Yes_Lowercase => "yes";
        public string Yes_PascalCase => "Yes";
        public string Yes_UpperCase => "YES";
        /// <summary>
        /// Chooses <see cref="Yes_PascalCase"/> as the default.
        /// </summary>
        public string Yes => this.Yes_PascalCase;

        public string True_Lowercase => "true";
        public string True_PascalCase => "True";
        public string True_Uppercase => "TRUE";
        /// <summary>
        /// Chooses <see cref="True_PascalCase"/> as the default.
        /// </summary>
        public string True => this.True_PascalCase;
        public string False_Lowercase => "false";
        public string False_PascalCase => "False";
        public string False_UpperCase => "FALSE";
        /// <summary>
        /// Chooses <see cref="False_PascalCase"/> as the default.
        /// </summary>
        public string False => this.False_PascalCase;
    }
}
