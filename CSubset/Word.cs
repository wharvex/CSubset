namespace CSubset;

public class Word
{
    public enum TokenType
    {
        // Solo
        Ampersand,
        Bang,
        Caret,
        Colon,
        Comma,
        Dot,
        Equal,
        FSlash,
        Minus,
        Percent,
        Pipe,
        Plus,
        Semicolon,
        Separator,
        Star,
        Tilde,

        // Solo Surround
        LParen,
        RParen,
        LCurly,
        RCurly,
        LSquare,
        RSquare,
        LAngle,
        RAngle,

        // Duo
        GreaterEqual,
        LessEqual,
        NotEqual,
        DblPlus,
        DblMinus,
        DblLAngle,
        DblRAngle,
        DblEqual,
        DblPipe,
        DblAmpersand,
        Arrow,

        // Ensemble
        Num,
        NumWithDot,
        Identifier,
        CharContents,
        StringContents,

        // Keywords
        AutoKw,
        BreakKw,
        CaseKw,
        CharKw,
        ConstKw,
        ContinueKw,
        DefaultKw,
        DoKw,
        DoubleKw,
        ElseKw,
        EnumKw,
        ExternKw,
        FloatKw,
        ForKw,
        GotoKw,
        IfKw,
        IntKw,
        LongKw,
        RegisterKw,
        ReturnKw,
        ShortKw,
        SignedKw,
        SizeofKw,
        StaticKw,
        StructKw,
        SwitchKw,
        TypedefKw,
        UnionKw,
        UnsignedKw,
        VoidKw,
        VolatileKw,
        WhileKw
    }
}
