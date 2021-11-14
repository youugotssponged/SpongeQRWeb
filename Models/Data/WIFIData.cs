using SpongeQRWeb.Models.Types;

namespace SpongeQRWeb.Models.Data;
public class WIFIData
{
    public string SSID { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public WIFIAuthTypes WifiAuthType { get; set; } = WIFIAuthTypes.None;
}
