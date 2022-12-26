using System.Text.RegularExpressions;

namespace UtmBuilder.core.ValueObjects;

public class Url : ValueObject
{
    private const string URLREGEXPATTERN = @"";
    public Url(string address)
    {
        Address = address;

       if( Regex.IsMatch(Address, URLREGEXPATTERN))
       {
        throw new Exception(message: "Url error");
       }
    }
    public string Address { get; }
}