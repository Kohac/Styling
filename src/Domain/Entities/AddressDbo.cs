using Example.Styling.Domain.Entities.Abstraction;

namespace Example.Styling.Domain.Entities;

public class AddressDbo : Entity
{
    public Guid CustomerId { get; init; }
    public string City { get; init; } = null!;
    public string? Country { get; init; }
    public int OrientationNumber { get; init; }
    public int HouseNumber { get; init; }
    public string? PostalCode { get; init; }

    public required CustomerDbo Customer { get; init; }
}