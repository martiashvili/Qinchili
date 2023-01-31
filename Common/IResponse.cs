namespace Common
{
    public interface IResponse<TResponse>
    {
        public TResponse? Data { get; set; }

        public Status Status { get; set; }
    }
}