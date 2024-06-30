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
    public static Dictionary<char, CharTypes> CharTypeByChar =>
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

    public static Dictionary<CharTypes, char> CharByCharType =>
        new()
        {
            [CharTypes.Zero] = '0',
            [CharTypes.One] = '1',
            [CharTypes.Two] = '2',
            [CharTypes.Three] = '3',
            [CharTypes.Four] = '4',
            [CharTypes.Five] = '5',
            [CharTypes.Six] = '6',
            [CharTypes.Seven] = '7',
            [CharTypes.Eight] = '8',
            [CharTypes.Nine] = '9',
        };

    public static CharTypes GetCharTypeByChar(char c)
    {
        return CharTypeByChar.GetValueOrDefault(c, CharTypes.Unrecognized);
    }

    public static char GetCharByCharType(CharTypes ct)
    {
        return CharByCharType.GetValueOrDefault(ct, '\0');
    }
}
