namespace RTrader.Domain.Common;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public DateTime CreatedOnUtc { get; set; }

    public DateTime? ModifiedOnUtc { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeletedOnUtc { get; set; }
}