using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace PaperPlease
{
    public class JsonReader
    { 
        public string? path { get; init; }
        public JsonReader(string? path) => this.path = path;

        public EntityData? GetEntities() 
        {
            if (this.path == null) throw new InvalidOperationException("Path has not been initialized."); ;
            string? jsonText = File.ReadAllText(this.path);
            EntityData? jsonData = JsonSerializer.Deserialize<EntityData>(jsonText);
            
            if (jsonData != null && jsonData.Data != null) return jsonData;

            return null;
        }
    }
}
