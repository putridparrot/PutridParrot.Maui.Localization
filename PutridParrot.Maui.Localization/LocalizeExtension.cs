using Microsoft.Extensions.Localization;

namespace PutridParrot.Maui.Localize;

// Taken from https://stackoverflow.com/questions/71315229/how-to-implement-net-maui-localization

[ContentProperty(nameof(Key))]
public class LocalizeExtension<TAppRes> : IMarkupExtension
{
    private readonly IStringLocalizer<TAppRes> _localizer;

    public string Key { get; set; } = string.Empty;

    public LocalizeExtension()
    {
        _localizer = ServiceHelper.GetService<IStringLocalizer<TAppRes>>();
    }

    public object ProvideValue(IServiceProvider _) => 
        _localizer[Key];

    object IMarkupExtension.ProvideValue(IServiceProvider serviceProvider) => ProvideValue(serviceProvider);
}