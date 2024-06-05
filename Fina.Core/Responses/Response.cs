using System.Text.Json.Serialization;

namespace Fina.Core.Responses
{
    public class Response<TData>
    {
        private int _code = Configuration.DefaultStatusCode;
        public TData? Data { get; set; }
        public string? Message { get; set; }

        [JsonIgnore]
        public bool IsSuccess => _code is >= 200 and <= 299;

        public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null)
        {
            Data = data;
            _code = code;
            Message = message;
        }

        [JsonConstructor]
        public Response() => _code = Configuration.DefaultStatusCode;
    }
}