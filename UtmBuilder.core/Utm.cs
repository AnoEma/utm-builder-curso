using UtmBuilder.core.ValueObjects;

namespace UtmBuilder.core;

public class Utm
{
    public Utm(Url url, Campaign campaign)
    {
        Url = url;
        Campaign = campaign;
    }

    public Url Url { get; }
    public Campaign Campaign { get; }
}