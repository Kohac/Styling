using Example.Styling.Domain.Entities.Abstraction;

namespace Example.Styling.Domain.Entities;

public class CustomerDbo : Entity
{
    public string? FirstName { get; set; }
    public string LastName { get; set; } = null!;
    public string? Email { get; set; }
    public string? Phone { get; set; }

    public IReadOnlyCollection<AddressDbo> Addresses { get; set; } = [];
}
