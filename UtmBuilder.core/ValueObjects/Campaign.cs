using UtmBuilder.core.ValueObjects.Exceptions;

namespace UtmBuilder.core.ValueObjects;

public class Campaign: ValueObject
{
    public Campaign
    (
        string id, 
        string source, 
        string medium, 
        string name, 
        string term, 
        string content
    )
    {
        Id = id;
        Source = source;
        Medium = medium;
        Name = name;
        Term = term;
        Content = content;

        InvalidCampaignException.ThrowIfInvalid(source, "Source is Invalid");
        InvalidCampaignException.ThrowIfInvalid(medium, "medium is Invalid");
        InvalidCampaignException.ThrowIfInvalid(name, "Name is Invalid");
    }

    public string Id { get; }
    public string Source { get; }
    public string Medium { get; }
    public string Name { get; }
    public string Term { get; }
    public string Content { get; }
}