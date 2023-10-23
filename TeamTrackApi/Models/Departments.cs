using System.Text.Json.Serialization;

namespace TeamTrackApi.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Departments
{
    Design,
    Candidate,
    Programmist,
    ProjactManager,
    Manager,
    STO,
    SMM,
}
