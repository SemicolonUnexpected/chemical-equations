namespace Chem;

internal enum TokenType {
    // Separators 
    ArrowRightToLeft, // '->', '=>' or ''
    ArrowBoth, // '<->', '<=>' or ''
    Plus, // '+'
    LeftParenthesis, // '('
    RightParenthesis, // ')'

    // Chemical equation components
    Element,
    Subscript, // Denoted by an underscore
    Superscript, // Denoted by the caret symbol
    Number
}
