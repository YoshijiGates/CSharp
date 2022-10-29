using Newtonsoft.Json;


namespace JsonFileIO.Jsons
{
    [JsonObject("PersonJson")]
    public sealed class PersonJson
    {
        [JsonProperty("Name")]
        public string Name { get; set; }    // 名前

        [JsonProperty("Age")]
        public int Age { get; set; }    // 年齢

        [JsonProperty("Height")]
        public double Height { get; set; }  // 身長

    }
}
