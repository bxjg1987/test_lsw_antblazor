using FYJ.IOT.TenantApp.Localization;
using Volo.Abp.AspNetCore.Components;

namespace FYJ.IOT.TenantApp;

public abstract class TenantAppComponentBase : AbpComponentBase
{
    protected TenantAppComponentBase()
    {
        LocalizationResource = typeof(TenantAppResource);
    }
}
