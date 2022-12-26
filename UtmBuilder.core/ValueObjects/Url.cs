namespace UtmBuilder.core.ValueObjects;

public class Url : ValueObject
{
    public Url(string address)
    {
        Adress = address;
    }
    public string Adress { get; }
}