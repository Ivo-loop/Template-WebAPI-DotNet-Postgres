namespace Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string CreatedBy { get; private set; }
    public DateTime LastUpdatedAt { get; private set; }
    public string LastUpdatedBy { get; private set; }
    public bool Active { get; private set; }

    protected void SetCreate(string requestedBy)
    {
        Id = Guid.NewGuid();
        CreatedAt = DateTime.UtcNow;
        CreatedBy = requestedBy;
        SetUpdate(requestedBy);
        Active = true;
    }

    protected void SetInactive(string requestedBy)
    {
        SetUpdate(requestedBy);
        Active = false;
    }

    protected void SetUpdate(string requestedBy)
    {
        LastUpdatedAt = DateTime.UtcNow;
        LastUpdatedBy = requestedBy;
    }
}