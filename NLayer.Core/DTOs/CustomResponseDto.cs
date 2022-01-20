using System.Text.Json.Serialization;

namespace NLayer.Core.DTOs
{
    public class CustomResponseDto<T>
    {
        public T? Data { get; set; }
        public List<string>? Errors { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }

        public static CustomResponseDto<T> Success(int statusCode, T data) => new() { StatusCode = statusCode, Data = data };
        public static CustomResponseDto<T> Success(int statusCode) => new() { StatusCode = statusCode };
        public static CustomResponseDto<T> Fail(List<string> errors, int statusCode) => new() { StatusCode = statusCode, Errors = errors };
        public static CustomResponseDto<T> Fail(string error, int statusCode) => new() { StatusCode = statusCode, Errors = new() { error } };
    }
}
