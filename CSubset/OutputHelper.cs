namespace CSubset;

public class OutputHelper
{
    public static string DocPath { get; } =
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    public static void DebugPrintTxt(string output, string suffix, bool append = false)
    {
        using var outputFile = new StreamWriter(
            Path.Combine(DocPath, "CSubsetDebugOutput_" + suffix + ".txt"),
            append
        );
        outputFile.WriteLine(output);
    }
}
