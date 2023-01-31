namespace Common
{
    public class Response<TResponse> : IResponse<TResponse>
    {
        public TResponse? Data { get; set; }

        public Status Status { get; set; }
    }
}
