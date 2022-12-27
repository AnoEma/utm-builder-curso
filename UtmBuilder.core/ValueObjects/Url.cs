using System.Text.RegularExpressions;
namespace UtmBuilder.core.ValueObjects;

public class Url : ValueObject
{

    public Url(string address)
    {
        Address = address;
    }
    public string Address { get; }
}