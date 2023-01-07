using System.Text.Json;
using Grpc.Core;
using GrpcService.Server.Contracts;

namespace GrpcService.Server.Services;

public class CommentService : Server.CommentService.CommentServiceBase
{
    private readonly IHttpClientFactory _httpClientFactory;

    public CommentService(IHttpClientFactory httpClientFactory)
    {
        _httpClientFactory = httpClientFactory;
    }

    public override async Task<GetCommentsByPostResponse> GetCommentsByPost(GetCommentsByPostRequest request, ServerCallContext context)
    {
        var httpClient = _httpClientFactory.CreateClient();
        var responseText = await httpClient.GetStringAsync(
            $"https://jsonplaceholder.typicode.com/comments?postId={request.PostId}");

        var commentsResult = JsonSerializer.Deserialize<List<CommentDto>>(responseText);

        var comments = commentsResult?.ConvertAll(x => new Comment()
        {
            Body = x.Body,
            Name = x.Name,
        });
        
        var result = new GetCommentsByPostResponse
        {
            Comments = { comments }
        };
        
        return result;
    }
}