using SpongeQRWeb.Models.Types;

namespace SpongeQRWeb.Models.Data;

public class CalendarData
{
    public string Subject { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }// address or lat/long
    public DateTime DateStart { get; set; }
    public DateTime DateEnd { get; set; }
    public bool IsEventAllDay { get; set; }
    public CalendarEncodeTypes CalendarEncodeType { get; set; }
}
