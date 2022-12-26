namespace UtmBuilder.core.ValueObjects.Exceptions;

public class InvalidUrlException : Exception
{
    public InvalidUrlException(string message = "Invalid Url") : base(message)
    {
    }

}