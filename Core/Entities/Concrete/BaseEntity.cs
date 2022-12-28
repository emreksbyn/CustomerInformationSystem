namespace Core.Entities.Concrete
{
    public class BaseEntity<T> : IEntity
    {
        public T Id { get; set; }
    }
}