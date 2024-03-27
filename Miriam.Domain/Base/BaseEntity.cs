namespace Miriam.Domain.Base;

public abstract class BaseEntity<T>
{
    public virtual required T Id { get; set; }
}