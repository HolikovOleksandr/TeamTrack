using System.Text.Json.Serialization;

namespace TeamTrackApi.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Departments
{
    First = 1,
    Second = 2,
}
