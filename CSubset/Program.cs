using CommandLine;
using CSubset.FiniteAutomata;

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

        opts.InputFiles.ToList().ForEach(Console.WriteLine);
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
