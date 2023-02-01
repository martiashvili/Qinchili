using Common.Enums;

namespace Common
{
    public static class ResponseHelper
    {
        public static IResponse<TResponse> Ok<TResponse>(TResponse data)
            where TResponse : class
        {
            return new Response<TResponse>
            {
                Data = data,
                Status = new Status
                {
                    StatusCode = StatusCode.Success
                }
            };
        }

        public static IResponse<EmptyResponse> Ok(string? message = null)
        {
            return new Response<EmptyResponse>
            {
                Status = new Status
                {
                    StatusCode = StatusCode.Success,
                    Message = message
                }
            };
        }

        public static IResponse<TResponse> Fail<TResponse>(StatusCode statusCode = StatusCode.Fail, string? message = null, TResponse? data = null)
           where TResponse : class
        {
            return new Response<TResponse>
            {
                Data = data,
                Status = new Status
                {
                    StatusCode = statusCode,
                    Message = message ?? statusCode.ToString()
                }
            };
        }
    }
}
