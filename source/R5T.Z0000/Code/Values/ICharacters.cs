using System;

using R5T.T0131;


namespace R5T.Z0000
{
    /// <summary>
    /// Characters by name.
    /// See: <see href="https://www.ascii-code.com/"/>
    /// </summary>
    [ValuesMarker]
    public interface ICharacters : IValuesMarker
    {
        public char Ampersand => '&';
        public char Apostrophe => '\'';
        public char Asterix => '*';
        /// <summary>
        /// Also known as "alphasands".
        /// </summary>
        public char At => '@';
        public char Backslash => '\\';
        /// <summary>
        /// Also known as the circumflex, or up-caret.
        /// </summary>
        public char Caret => '^';
        public char CloseBrace => ']';
        public char CloseParenthesis => ')';
        public char Colon => ':';
        public char Comma => ',';
        public char DoubleQuote => this.Quote;
        public char Equals => '=';
        /// <summary>
        /// Strangely, in Visual Studio form-feed prints as the feminine (Venus) symbol.
        /// </summary>
        public char ExclamationMark => '!';
        public char FormFeed => '';
        public char LessThan => '<';
        public char Minus => '-';
        public char NewLine => '\n';
        /// <summary>
        /// Sometimes the next-line character is represented as ellipsis (...).
        /// </summary>
        public char NextLine => '\x85';
        public char OpenBrace => '[';
        public char OpenParenthesis => '(';
        public char Period => '.';
        public char Pipe => '|';
        public char Plus => '+';
        public char Pound => '#';
        public char QuestionMark => '?';
        /// <summary>
        /// The '"' (quote, double-quote, or quotation mark) character.
        /// </summary>
        public char Quote => '"';
        public char Semicolon => ';';
        public char SingleQuote => this.Apostrophe;
        public char Slash => '/';
        public char Space => ' ';
        public char Tab => '\t';
        public char Tick => '`';
        public char Underscore => '_';
        /// <summary>
        /// Strangely, in Visual Studio form-feed prints as the masculine (Mars) symbol.
        /// </summary>
        public char VerticalTab => '';

        /// <summary>
        /// A latin ligature of 'A' and 'E', or the Old English ash, which is the sound in "hat" or "pattern" (as opposed to the sound in "father" or "car").
        /// </summary>
        public char Ash_Uppercase => 'Æ';
        public char I_Uppercase => 'I';
        /// <summary>
        /// The 'th" in thorn.
        /// </summary>
        public char Thorn_Uppercase => 'Þ';
        public char X_Uppercase => 'X';
        public string X_Uppercase_Hat => "X̂";
        public string X_Uppercase_Underbar => "X̲";

#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Ash_Uppercase"/>
        public char Ash_Lowercase => 'æ';
        public char s_Lowercase => 's';
        /// <inheritdoc cref="Thorn_Uppercase"/>
        public char Thorn_Lowercase => 'þ';
        public char X_Lowercase => 'x';

#pragma warning restore IDE1006 // Naming Styles
    }
}
