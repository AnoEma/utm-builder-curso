using UtmBuilder.core.ValueObjects;

namespace UtmBuilder.core;

public class Utm
{
    public Url Url { get; set; };
    public Campaign Campaign { get; set; } = new();

}