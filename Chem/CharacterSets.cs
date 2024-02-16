namespace Chem;

internal static class CharacterSets {
    private const Dictionary<char, char> _subSuperScriptable = new() {
        { '1', '' },
    };

    public static bool IsSubSuperScriptable(char test) => _subSuperScriptable.ContainsKey(test);
}
