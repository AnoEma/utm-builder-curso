namespace UtmBuilder.core.ValueObjects.Exceptions;

public class InvalidCampaignException : Exception
{
     private const string DEFAULT_ERROR_MESSAGE = "Invalid UTM parameters";
    public InvalidCampaignException(string message = DEFAULT_ERROR_MESSAGE) : base(message)
    {
    }

    public static void ThrowIfInvalid(string address, string message = DEFAULT_ERROR_MESSAGE)
    {
        if(string.IsNullOrEmpty(address))
        {
            throw new InvalidCampaignException(message);
        }
    }
}