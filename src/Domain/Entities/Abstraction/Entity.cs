namespace Example.Styling.Domain.Entities.Abstraction;

public abstract class Entity
{
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime? Updated { get; set; }
    public DateTime? Deleted { get; set; }
}
