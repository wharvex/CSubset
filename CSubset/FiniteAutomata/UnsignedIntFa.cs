namespace CSubset.FiniteAutomata;

public class UnsignedIntFa : IFiniteAutomaton
{
    public StateTypes States => StateTypes.S0 | StateTypes.S1 | StateTypes.S2;
    public StateTypes FinalStates => StateTypes.S1 | StateTypes.S2;
    public CharTypes Alphabet =>
        IFiniteAutomaton.GetAlphabet(
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
        );

    public StateTypes? Delta(StateTypes s, CharTypes c) =>
        s switch
        {
            _ when !States.HasFlag(s) => throw new InvalidOperationException("Unrecognized state."),
            _ when !Alphabet.HasFlag(c) => null,
            StateTypes.S0 when c == CharTypes.Zero => StateTypes.S1,
            StateTypes.S0
                when IFiniteAutomaton
                    .GetAlphabet(
                        CharTypes.One,
                        CharTypes.Two,
                        CharTypes.Three,
                        CharTypes.Four,
                        CharTypes.Five,
                        CharTypes.Six,
                        CharTypes.Seven,
                        CharTypes.Eight,
                        CharTypes.Nine
                    )
                    .HasFlag(c)
                => StateTypes.S2,
            StateTypes.S2 when Alphabet.HasFlag(c) => StateTypes.S2,
            StateTypes.S1 when Alphabet.HasFlag(c)
                => throw new InvalidOperationException("Number Cannot Start With Zero."),
            _ => throw new InvalidOperationException("Unrecognized Delta config.")
        };
}
