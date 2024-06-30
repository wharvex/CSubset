namespace CSubset.FiniteAutomata;

[Flags]
public enum CharTypes
{
    None = 0,
    Zero = 1 << 0,
    One = 1 << 1,
    Two = 1 << 2,
    Three = 1 << 3,
    Four = 1 << 4,
    Five = 1 << 5,
    Six = 1 << 6,
    Seven = 1 << 7,
    Eight = 1 << 8,
    Nine = 1 << 9,
    Unrecognized = 1 << 10,
}

public static class CharTypesHelper
{
    public static Dictionary<char, CharTypes> CharTypesMap =>
        new()
        {
            ['0'] = CharTypes.Zero,
            ['1'] = CharTypes.One,
            ['2'] = CharTypes.Two,
            ['3'] = CharTypes.Three,
            ['4'] = CharTypes.Four,
            ['5'] = CharTypes.Five,
            ['6'] = CharTypes.Six,
            ['7'] = CharTypes.Seven,
            ['8'] = CharTypes.Eight,
            ['9'] = CharTypes.Nine,
        };

    public static CharTypes GetCharTypeByChar(char c)
    {
        return CharTypesMap.GetValueOrDefault(c, CharTypes.Unrecognized);
    }

    public static char GetCharByCharType(CharTypes ct)
    {
        return CharTypesMap
            .Where(kvp => kvp.Value == ct)
            .Select(kvp => kvp.Key)
            .FirstOrDefault('\0');
    }

    public static CharTypes GetAlphabetFor(IFiniteAutomaton fa) =>
        fa switch
        {
            UnsignedIntFa
                => GetAlphabet(
                    CharTypes.Zero,
                    CharTypes.One,
                    CharTypes.Two,
                    CharTypes.Three,
                    CharTypes.Four,
                    CharTypes.Five,
                    CharTypes.Six,
                    CharTypes.Seven,
                    CharTypes.Eight,
                    CharTypes.Nine
                ),
            _ => throw new InvalidOperationException()
        };

    public static CharTypes GetAlphabet(CharTypes baseCt, params CharTypes[] cts)
    {
        // This should return baseCt if cts is empty.
        return cts.Aggregate(baseCt, (acc, nxt) => acc | nxt);
    }
}
