using System;

using R5T.T0131;

using StringsDocumentation = R5T.Y0006.Documentation.ForStrings;


namespace R5T.Z0000
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker
    {
        public string Ampersand => "&";
        public string Apostrophe => "'";

        /// <inheritdoc cref="StringsDocumentation.ForAsterix"/>
        public string Asterix => "*";

        public string At => "@";
        public string Backslash => @"\";
        /// <inheritdoc cref="ICharacters.CloseAngleBracket"/>
        public string CloseAngleBracket => ">";
        public string CloseBrace => "}";
        /// <summary>
        /// "]"
        /// </summary>
        public string CloseBracket => "]";
        /// <inheritdoc cref="ICharacters.CloseParenthesis"/>
        public string CloseParenthesis => ")";
        public string Colon => ":";
        /// <inheritdoc cref="ICharacters.Comma"/>
        public string Comma => ",";

        /// <summary>
        /// ", " - Comma and then a space.
        /// </summary>
        public const string CommaSeparatedListSpacedSeparator_Constant = ", ";

        /// <inheritdoc cref="CommaSeparatedListSpacedSeparator_Constant"/>
        public string CommaSeparatedListSpacedSeparator => IStrings.CommaSeparatedListSpacedSeparator_Constant;

        /// <inheritdoc cref="ICharacters.Copyright_Constant"/>
        public const string Copyright_Constant = "©";

        /// <inheritdoc cref="IStrings.Copyright_Constant"/>
        public string Copyright => IStrings.Copyright_Constant;

        public string Dash => "-";
        public string DoubleDot => "..";
        public string DoubleEquals => "==";
        public string DoubleQuote => this.Quote;
        public string DoubleSlash => "//";
        public string DoubleSpaces => "  ";
        public string Ellipsis => "...";

        /// <inheritdoc cref="StringsDocumentation.ForEmpty_Constant"/>
        public const string Empty_Constant = "";

        /// <inheritdoc cref="StringsDocumentation.ForEmpty"/>
        public string Empty => IStrings.Empty_Constant;

        /// <inheritdoc cref="StringsDocumentation.ForEquals"/>
        public const string Equals_Constant = "=";

        /// <inheritdoc cref="Equals_Constant"/>
        public string Equals => IStrings.Equals_Constant;

        /// <summary>
        /// "&lt;empty&gt;"
        /// </summary>
        public string Empty_TextRepresentation => "<empty>";
        public string GreaterThan => ">";
        public string Hash => "#";
        /// <summary>
        /// "·" - the interpunct.
        /// </summary>
        public const string Interpunct_Const = "·";
        /// <inheritdoc cref="Interpunct_Const"/>
        public string Interpunct => IStrings.Interpunct_Const;
        public string LessThan => "<"; // No other name for it: https://english.stackexchange.com/questions/255262/what-is-the-name-of-the-symbols-and
        /// <summary>
        /// The actual value, null.
        /// </summary>
        public const string Null_Constant = null;
        /// <inheritdoc cref="Null_Constant"/>
        public string Null => IStrings.Null_Constant;
        /// <summary>
        /// "null"
        /// </summary>
        public string Null_StandardRepresentation => "null";
        /// <summary>
        /// "&lt;null&gt;"
        /// </summary>
        public string Null_TextRepresentation => "<null>";
        /// <summary>
        /// Chooses <see cref="NewLine_Windows"/> as the default.
        /// </summary>
        public string NewLine => this.NewLine_Windows;
        /// <summary>
        /// "\r\n"
        /// </summary>
        public const string NewLine_Windows_Constant = "\r\n";
        /// <inheritdoc cref="NewLine_Windows_Constant"/>
        public string NewLine_Windows => IStrings.NewLine_Windows_Constant;

        /// <inheritdoc cref="StringsDocumentation.ForNewLine"/>
        public const string NewLine_NonWindows_Constant = "\n";

        /// <inheritdoc cref="NewLine_NonWindows_Constant"/>
        public string NewLine_NonWindows => IStrings.NewLine_NonWindows_Constant;

        public string NewLine_TextRepresentation => "<newline>";

        /// <inheritdoc cref="ICharacters.OpenAngleBracket"/>
        public string OpenAngleBracket => "<";
        public string OpenBrace => "{";
        /// <summary>
        /// "["
        /// </summary>
        public string OpenBracket => "[";
        /// <inheritdoc cref="ICharacters.OpenParenthesis"/>
        public string OpenParenthesis => "(";
        public string PairedParentheses => "()";
        public string Percent => "%";

        /// <inheritdoc cref="StringsDocumentation.ForPeriod"/>
        public string Period => ".";

        public const string Period_Const = ".";

        /// <inheritdoc cref="StringsDocumentation.ForPipe"/>
        public string Pipe => "|";

        public string PipeSpace => "| ";
        public string QuestionMark => "?";

        /// <inheritdoc cref="StringsDocumentation.ForQuote"/>
        public string Quote => "\"";

        public string Semicolon => ";";
        public string SingleQuote => this.Apostrophe;

        /// <inheritdoc cref="StringsDocumentation.ForSpace"/>
        public const string Space_Const = " ";
        
        /// <inheritdoc cref="Space_Const"/>
        public string Space => IStrings.Space_Const;

        /// <inheritdoc cref="ICharacters.Slash"/>
        public string Slash => IStrings.Slash_Constant;
        /// <inheritdoc cref="ICharacters.Slash"/>
        public const string Slash_Constant = "/";

        /// <inheritdoc cref="StringsDocumentation.ForTab"/>
        public const string Tab_Constant = "\t";

        /// <inheritdoc cref="Tab_Constant"/>
        public string Tab => IStrings.Tab_Constant;

        /// <summary>
        /// "&lt;tab&gt;"
        /// </summary>
        public string Tab_TextRepresentation => "<tab>";
        public string Underscore => "_";

        public string A_Uppercase => "A";
        public string I_Uppercase => "I";

#pragma warning disable IDE1006 // Naming Styles

        public string s_Lowercase => "s";

#pragma warning restore IDE1006 // Naming Styles

        /// <summary>
        /// <inheritdoc cref="Environment.NewLine" path="/returns"/>
        /// </summary>
        public string NewLine_ForEnvironment => Environment.NewLine;

        public string No_Lowercase => "no";
        public string No_PascalCase => "No";
        public string No_UpperCase => "NO";
        /// <summary>
        /// Chooses <see cref="No_PascalCase"/> as the default.
        /// </summary>
        public string No => this.No_PascalCase;
        /// <summary>
        /// "&lt;empty&gt;"
        /// </summary>
        public string None_TextRepresentation => "<none>";
        public string Yes_Lowercase => "yes";
        public string Yes_PascalCase => "Yes";
        public string Yes_UpperCase => "YES";
        /// <summary>
        /// Chooses <see cref="Yes_PascalCase"/> as the default.
        /// </summary>
        public string Yes => this.Yes_PascalCase;

        /// <inheritdoc cref="StringsDocumentation.ForTrue_Lowercase"/>
        public string True_Lowercase => "true";

        /// <inheritdoc cref="StringsDocumentation.ForTrue_PascalCase"/>
        public string True_PascalCase => "True";

        /// <inheritdoc cref="StringsDocumentation.ForTrue_Uppercase"/>
        public string True_Uppercase => "TRUE";

        /// <summary>
        /// Chooses <see cref="True_PascalCase"/> as the default.
        /// </summary>
        public string True => this.True_PascalCase;

        /// <inheritdoc cref="StringsDocumentation.ForFalse_Uppercase"/>
        public string False_Lowercase => "false";

        /// <inheritdoc cref="StringsDocumentation.ForFalse_Uppercase"/>
        public string False_PascalCase => "False";

        /// <inheritdoc cref="StringsDocumentation.ForFalse_Uppercase"/>
        public string False_UpperCase => "FALSE";

        /// <summary>
        /// Chooses <see cref="False_PascalCase"/> as the default.
        /// </summary>
        public string False => this.False_PascalCase;
    }
}
