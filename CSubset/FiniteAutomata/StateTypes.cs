namespace CSubset.FiniteAutomata;

[Flags]
public enum StateTypes
{
    None = 0,
    S0 = 1 << 0,
    S1 = 1 << 1,
    S2 = 1 << 2,
    S3 = 1 << 3,
    S4 = 1 << 4,
    S5 = 1 << 5,
    S6 = 1 << 6,
    S7 = 1 << 7,
    S8 = 1 << 8,
    S9 = 1 << 9
}
