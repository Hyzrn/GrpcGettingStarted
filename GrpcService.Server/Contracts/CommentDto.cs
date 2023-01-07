using System.Text.Json.Serialization;

namespace GrpcService.Server.Contracts;

public class CommentDto
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    
    [JsonPropertyName("body")]
    public string Body { get; set; }
}