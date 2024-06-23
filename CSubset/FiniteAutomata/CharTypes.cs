namespace CSubset.FiniteAutomata;

[Flags]
public enum CharTypes
{
    Zero = 1,
    One = 2,
    Two = 4,
    Three = 8,
    Four = 16,
    Five = 32,
    Six = 64,
    Seven = 128,
    Eight = 256,
    Nine = 512,
    ZeroThruNine = Zero | One | Two | Three | Four | Five | Six | Seven | Eight | Nine,
    OneThruNine = One | Two | Three | Four | Five | Six | Seven | Eight | Nine
}
