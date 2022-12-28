namespace Core.Responses
{
    public class Response<TEntity> : IResponse<TEntity> where TEntity : class, new()
    {
        public TEntity? Data { get; private set; }

        public bool IsSuccessful { get; private set; }

        public string Message { get; private set; }

        public static Response<TEntity> Success(string message)
        {
            return new Response<TEntity> { Data = default(TEntity), IsSuccessful = true, Message = message };
        }

        public static Response<TEntity> Success(TEntity data, string message)
        {
            return new Response<TEntity> { Data = data, IsSuccessful = true, Message = message };
        }

        public static Response<TEntity> Fail(string message)
        {
            return new Response<TEntity> { Data = default(TEntity), IsSuccessful = false, Message = message };
        }
    }
}
