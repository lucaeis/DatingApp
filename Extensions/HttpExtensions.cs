using System.Text.Json;
using API.Helpers;

namespace API.Extensions
{ 
    public static class HttpExtensions
    {
        public static void AddPaginationHeader(this HttpResponse responser, PaginationHeader header)
        {
            var jsonOptions = new JsonSerializerOptions{PropertyNamingPolicy = JsonNamingPolicy.CamelCase};
            responser.Headers.Add("Pagination", JsonSerializer.Serialize(header, jsonOptions));
            responser.Headers.Add("Access-Control-Expose-Headers", "Pagination");
        }
    }
}