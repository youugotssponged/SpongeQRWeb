using SpongeQRWeb.Models.Types;
using static QRCoder.PayloadGenerator;

namespace SpongeQRWeb.Helpers;
public static class TypeMappingHelper
{
    public static WiFi.Authentication MapWIFITypeToAuthenticationType(WIFIAuthTypes WIFIAuth) =>
        WIFIAuth switch
        {
            WIFIAuthTypes.WPA or WIFIAuthTypes.WPA2 => WiFi.Authentication.WPA,
            WIFIAuthTypes.WEP => WiFi.Authentication.WEP,
            WIFIAuthTypes.None => WiFi.Authentication.nopass,
            _ => WiFi.Authentication.WPA
        };

    public static CalendarEvent.EventEncoding MapCalendarTypeToCalendarEventEncodingType(CalendarEncodeTypes CalendarType) => 
        CalendarType switch
        {
            CalendarEncodeTypes.UNIVERSAL => CalendarEvent.EventEncoding.Universal,
            CalendarEncodeTypes.ICAL => CalendarEvent.EventEncoding.iCalComplete,
            _ => CalendarEvent.EventEncoding.Universal // Default
        };
}