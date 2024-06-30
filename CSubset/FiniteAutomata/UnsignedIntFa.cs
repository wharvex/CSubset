using System.Runtime.Serialization;
using System.Text;

namespace CSubset.FiniteAutomata;

public class UnsignedIntFa : IFiniteAutomaton
{
    public StringBuilder Contents { get; } = new();
    public string ContentsString => Contents.ToString();
    public StateTypes States => StateTypes.S0 | StateTypes.S1 | StateTypes.S2;
    public StateTypes FinalStates => StateTypes.S1 | StateTypes.S2;
    public CharTypes Alphabet => CharTypesHelper.GetAlphabetFor(this);

    public StateTypes? Delta(StateTypes s, CharTypes c)
    {
        if (!Alphabet.HasFlag(c))
        {
            return null;
        }

        switch (s)
        {
            case StateTypes.S0 when c == CharTypes.Zero:
                Contents.Append(CharTypesHelper.GetCharByCharType(c));
                return StateTypes.S1;
            case StateTypes.S0 when (Alphabet & ~CharTypes.Zero).HasFlag(c):
                Contents.Append(CharTypesHelper.GetCharByCharType(c));
                return StateTypes.S2;
            case StateTypes.S2:
                Contents.Append(CharTypesHelper.GetCharByCharType(c));
                return StateTypes.S2;
            case StateTypes.S1:
                throw new InvalidOperationException(
                    "Multi-digit integer-literals cannot start with `0'."
                );
            default:
                throw new InvalidOperationException("Unrecognized state for UnsignedIntFa.");
        }
    }
}
