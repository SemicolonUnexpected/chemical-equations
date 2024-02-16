namespace Chem;

public class Equation : IComparable<Equation> {
    // Under the hood, an equation is just a list of tokens
    private List<Token> _tokens = new();

    public bool IsBalanced => throw new NotImplementedException();

    public Equation(string equation) {
        var lex = new EquationLexer(equation);
        foreach (var t in lex.Lex()) Console.WriteLine(t.ToString());
    }

    public void Balance() {}

    // Equations are compared
    public int CompareTo(Equation? other) {
        if (other is null) throw new NullReferenceException("Cannot compare null values");

        throw new NotImplementedException();
    }

    // Pretty print the equation
    public override string ToString() {
        throw new NotImplementedException();
    }
}
