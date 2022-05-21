using SpongeQRWeb.Models.Types;

namespace SpongeQRWeb.Models.Data;
public class WIFIData
{
    public string SSID { get; set; }
    public string Password { get; set; }
    public WIFIAuthTypes WifiAuthType { get; set; } = WIFIAuthTypes.None;
}
