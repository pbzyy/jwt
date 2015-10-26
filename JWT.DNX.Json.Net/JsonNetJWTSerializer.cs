using Newtonsoft.Json;

namespace JWT.DNX.Json.Net
{
    public class JsonNetJWTSerializer : IJsonSerializer
    {
        private JsonSerializerSettings settings;

        public JsonNetJWTSerializer(JsonSerializerSettings settings = null)
        {
            this.settings = settings ?? new JsonSerializerSettings();
        }

        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json, settings);
        }

        public string Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj, settings);
        }
    }
}
