using System.Globalization;

namespace PutridParrot.Maui.Localize;

/// <summary>
/// Helper class for setting the culture across an application's various
/// culture properties
/// </summary>
public static class Localize
{
    public static void SetCurrentCulture(string culture) =>
        SetCurrentCulture(new CultureInfo(culture));

    public static void SetCurrentCulture(CultureInfo cultureInfo)
    {
        CultureInfo.CurrentUICulture = cultureInfo;
        Thread.CurrentThread.CurrentCulture = CultureInfo.CurrentUICulture;
        Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentUICulture;
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.CurrentUICulture;
        CultureInfo.DefaultThreadCurrentUICulture = CultureInfo.CurrentUICulture;
    }

}