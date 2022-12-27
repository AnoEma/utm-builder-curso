using UtmBuilder.core.ValueObjects.Exceptions;

namespace UtmBuilder.core.ValueObjects;

public class Url : ValueObject
{

    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(address);
    }
    public string Address { get; }
}