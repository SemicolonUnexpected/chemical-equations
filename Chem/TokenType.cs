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
    Subscript,
    BalancingNumber,
    AqueousStateSymbol,
    SolidStateSymbol,
    LiquidStateSymbol,
    GasStateSymbol,
    PrecipitateStateSymbol
}
