using System.Text.Json.Serialization;

namespace TrainingSWheels.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Warrior,
        Shaman,
        Healer
    }
}
