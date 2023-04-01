using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace FYJ.IOT.TenantApp;

[Dependency(ReplaceServices = true)]
public class TenantAppBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TenantApp";
}
