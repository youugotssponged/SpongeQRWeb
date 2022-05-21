using SpongeQRWeb.Models.Types;

namespace SpongeQRWeb.Core;
public class GenerateQRLogic
{

    public GenerateQRLogic()
    {
    }

    public void GenerateMessageQR(string Message)
    {
    }

    public void GenerateEmailQR(string EmailAddr, string Subject, string MessageBody)
    {
    }

    public void GenerateURLQR(string Url)
    {
    }

    public void GeneratePhoneNumberQR(string PhoneNumber)
    {
    }

    public void GenerateWIFIQR(string SSID, string Password, WIFIAuthTypes AuthType)
    {
        //WiFi.Authentication auth = CheckWIFIAuthTypeSelected(authMode);

        //WiFi generator = new WiFi(ssid, password, auth);

    }

    // TODO:
    // Break params into their own objs, possibly models for the subject, description, location
    public void GenerateCalendarEventQR(DateTime DateStart, DateTime DateEnd, bool AllDay,
        string Subject, string Description, string Location, CalendarEncodeTypes CalendarType)
    {
        // Check and map encoding types
        //CalendarEvent.EventEncoding calendarType = CheckCalendarEncodeTypeSelected(mainWindow.calendarData.CalendarEncodeType);

        // Convert to payload, generate and update image view
        // CalendarEvent calendarGenerator = new CalendarEvent(subject, description, location, start, end, allday, calendarType);

    }

    public string GenerateQRData(string payload)
    {
        return "";
    }
}