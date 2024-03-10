using static Chem.TokenType;

namespace Chem;

public record Equation {
    // Under the hood, an equation is just a list of components, which in turn are just a wrapper for a list of tokens
    private List<EquationComponent> _components = new();

    public Equation(string equation) {
        EquationLexer lexer = new(equation);
        _components = lexer.Lex();
    }

    private void ParseTokens(List<Token> tokens) {
        int start = 0;

        for (int i = 0; i < tokens.Count; i++) {
            switch(tokens[i].Type) {
                case Plus :
                    _components.Add(new EquationComponent(tokens.Slice(start, i - 1)));

                    // Skip over the plus and update the start position
                    i++;
                    start = i;
                    break;
                case ArrowLeftToRight :
                case ArrowRightToLeft :
                case ArrowReversible :
                    _components.Add(new EquationComponent(tokens.Slice(start, i - 1)));

                    // Skip over the arrow and update the start position
                    i++;
                    start = i;
                    break;
                default : break;
            }
        }
    }



                

    // Pretty print the equation
    public override string ToString() {
        return string.Join("", _components).Trim();
    }

//    public bool Equals(Equation? other) {
//        if (other is null) return false;
//        if (other._tokens.Count != _tokens.Count) return false;
//
//        List<List<Token>> equationSection = new();
//        List<List<Token>> equationSectionOther = new();
//
//        int start = 0;
//        int startOther = 0;
//        for (int i = 0; i < _tokens.Count; i++) {
//            if (_tokens[i] == Plus) {
//                equationSectionOther = 
//        }
//    }
}
