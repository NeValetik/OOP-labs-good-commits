using System;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace PaperPlease
{
    public class JsonOutter
    {
        public string? outterPath { get; init;}
        public JsonOutter(string? path) => this.outterPath = path;
        public void WriteUniversesToFile(Dictionary<string, Universe> universes)
        {
            if (outterPath == null) throw new InvalidOperationException("OutterPath has not been initialized.");

            try
            {
                foreach (var universe in universes)
                {
                    string? outputPath = Path.Combine(outterPath, $"{universe.Key}.json");
                    string json = JsonSerializer.Serialize(universe.Value, new JsonSerializerOptions { WriteIndented = true, DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull });
                    File.WriteAllText(outputPath, json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to file: {ex.Message}");
            }
        }
    }
}
