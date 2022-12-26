using System.Text.RegularExpressions;
using UtmBuilder.core.ValueObjects.Exceptions;

namespace UtmBuilder.core.ValueObjects;

public class Url : ValueObject
{
    private const string URLREGEXPATTERN = @"";
    public Url(string address)
    {
        Address = address;

       if( Regex.IsMatch(Address, URLREGEXPATTERN))
       {
        throw new InvalidUrlException(message: "Erro de url");
       }
    }
    public string Address { get; }
}