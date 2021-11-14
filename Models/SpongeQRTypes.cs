namespace SpongeQRWeb.Models.Types;
public enum QRTypes : int
{
    Message,
    Email,
    PhoneNumber,
    URL,
    WIFI,
    CalendarEvent
}

public enum WIFIAuthTypes : int
{
    None,
    WEP,
    WPA,
    WPA2
}

public enum CalendarEncodeTypes : int
{
    UNIVERSAL,
    ICAL
}