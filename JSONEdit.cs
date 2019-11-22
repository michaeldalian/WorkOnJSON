
using System.Collections.Generic;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace WorkOnJSON
{

    public static class JSONEdit
    {

        /// <summary>
        /// Write a Collection of objects in a JSON file
        /// </summary>
        /// <param name="myObjects">list of objects to Serialize</param>
        /// <param name="path">full name of the JSON File to write</param>
        public static void WriteCollectionToJSON(List<object> myObjects, string path, bool writeIndented = true
        , bool utf8Encoding = true, bool AllowTrailingCommas = true, bool IgnoreNullValues = false
        , bool IgnoreReadOnlyProperties = false, int MaxDepth = 0)
        {

            JsonSerializerOptions options = utf8Encoding ?
            new JsonSerializerOptions()
            { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) }
                         : new JsonSerializerOptions();
            options.WriteIndented = writeIndented;
            options.AllowTrailingCommas = AllowTrailingCommas;
            options.IgnoreNullValues = IgnoreNullValues;
            options.IgnoreReadOnlyProperties = IgnoreReadOnlyProperties;
            options.MaxDepth = MaxDepth;

            string json = JsonSerializer.Serialize(myObjects, typeof(List<object>), options);

            File.WriteAllText(path, json);
        }

        /// <summary>
        /// Writes an object to a JSON format file
        /// </summary>
        /// <param name="myObject">object to Serialize</param>
        /// <param name="path">full name of the JSON File to write</param>
        public static void WriteObjectToJSON(object myObject, string path, bool writeIndented = true
        , bool utf8Encoding = true, bool AllowTrailingCommas = true, bool IgnoreNullValues = false
        , bool IgnoreReadOnlyProperties = false, int MaxDepth = 0)
        {
            JsonSerializerOptions options = utf8Encoding ?
            new JsonSerializerOptions()
            { Encoder = System.Text.Encodings.Web.JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All) }
                         : new JsonSerializerOptions();
            options.WriteIndented = writeIndented;
            options.AllowTrailingCommas = AllowTrailingCommas;
            options.IgnoreNullValues = IgnoreNullValues;
            options.IgnoreReadOnlyProperties = IgnoreReadOnlyProperties;
            options.MaxDepth = MaxDepth;

            string json = JsonSerializer.Serialize(myObject, typeof(object), options);

            File.WriteAllText(path, json);
        }

        public async static Task<JsonElement> WriteJSONFileToJsonElement(string inputFileName)
        {
            using (FileStream fs = File.OpenRead(inputFileName))
            {
                return await JsonSerializer.DeserializeAsync<JsonElement>(fs);
            }
        }

    }

}
