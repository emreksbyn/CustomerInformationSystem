namespace Core.Responses
{
    public interface IResponse<TEntity>
    {
        TEntity? Data { get; }
        bool IsSuccessful { get; }
        string Message { get; }
    }
}