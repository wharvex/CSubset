using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CSubset;

public class OutputHelper
{
    public static string DocPath =>
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

    public static void DebugPrintTxt(string output, string suffix, bool append = false)
    {
        using var outputFile = new StreamWriter(
            Path.Combine(DocPath, "CSubsetDebugOutput_" + suffix + ".txt"),
            append
        );
        outputFile.WriteLine(output);
    }

    public static void DebugPrintJson(object obj, string suffix)
    {
        var jSets = new JsonSerializerSettings
        {
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            Converters = [new StringEnumConverter()],
            Formatting = Formatting.Indented,
            TypeNameHandling = TypeNameHandling.All
        };
        DebugPrintJsonOutput(JsonConvert.SerializeObject(obj, jSets), suffix);
    }

    public static void DebugPrintJsonOutput(string output, string suffix)
    {
        using var outputFile = new StreamWriter(
            Path.Combine(DocPath, "CSubsetDebugOutput_" + suffix + ".json")
        );
        outputFile.WriteLine(output);
    }
}
