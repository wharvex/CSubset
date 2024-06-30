using CommandLine;
using CSubset.FiniteAutomata;
using CSubset.Words;

namespace CSubset;

[Verb("interpret", HelpText = "Interpret the input file(s).")]
public class InterpretOptions
{
    [Option('r', "read", Required = true, HelpText = "Input files to be processed.")]
    public IEnumerable<string> InputFiles { get; set; } = [];
}

[Verb("compile", HelpText = "Compile the input file(s).")]
public class CompileOptions { }

[Verb("other", HelpText = "Do some secret third thing.")]
public class OtherOptions { }

public class Program
{
    public static int RunInterpretAndReturnExitCode(InterpretOptions opts)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine(
            "" + IFiniteAutomaton.GetAlphabet(CharTypes.Eight, CharTypes.One).HasFlag(CharTypes.One)
        );

        var files = opts.InputFiles.Select(File.ReadAllLines).ToList();
        files.ForEach(f => f.ToList().ForEach(Console.WriteLine));

        var filesByChar = opts.InputFiles.Select(File.ReadAllBytes).ToList();
        filesByChar.ForEach(f =>
        {
            if (f.Length == 0)
                return;
            var fa = new UnsignedIntFa();
            var i = 0;
            StateTypes? s = null,
                oldState;
            List<IWord> words = [];
            do
            {
                do
                {
                    oldState = s;
                    Console.WriteLine("oldState: " + oldState);
                    var nextChar = CharTypesHelper.GetCharTypeByChar((char)f[i++]);
                    Console.WriteLine("nextChar: " + nextChar);
                    Console.WriteLine("next char in alphabet: " + fa.Alphabet.HasFlag(nextChar));
                    s = fa.Delta(oldState ?? StateTypes.S0, nextChar);
                } while (s is not null && i < f.Length);

                Console.WriteLine("i: " + i);
                Console.WriteLine("fa contents: " + fa.ContentsString);
                if (fa.FinalStates.HasFlag(oldState ?? StateTypes.Unrecognized))
                {
                    // TODO: Figure out line numbers.
                    words.Add(new EnsembleWord(0, fa.ContentsString));
                    fa = new UnsignedIntFa();
                }
            } while (i < f.Length);
            Console.WriteLine("Words length: " + words.Count);
            words.ForEach(w => Console.WriteLine(((EnsembleWord)w).Contents));
        });
        return 0;
    }

    public static int RunCompileAndReturnExitCode(CompileOptions opts)
    {
        return 0;
    }

    public static int RunOtherAndReturnExitCode(OtherOptions opts)
    {
        return 0;
    }

    public static int Main(string[] args)
    {
        return CommandLine
            .Parser.Default.ParseArguments<InterpretOptions, CompileOptions, OtherOptions>(args)
            .MapResult(
                (InterpretOptions opts) => RunInterpretAndReturnExitCode(opts),
                (CompileOptions opts) => RunCompileAndReturnExitCode(opts),
                (OtherOptions opts) => RunOtherAndReturnExitCode(opts),
                errs => 1
            );
    }
}
