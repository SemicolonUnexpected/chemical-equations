namespace Chem;

internal enum TokenType {
    // Separators 
    ArrowLeftToRight, // '->'
    ArrowRightToLeft, // '<-'
    ArrowBoth, // '<->'
    Plus, // '+'
    LeftParenthesis, // '('
    RightParenthesis, // ')'

    // Chemical equation components
    Element,
    Subscript, // Denoted by an underscore
    Superscript, // Denoted by the caret symbol
    Number
}
