namespace Miriam.Domain.Base;

public abstract class BaseEntity<T>
{
    public T Id { get; set; }
}