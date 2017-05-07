
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Region")]
    public class RegionLookup : MultiTenantRowLookupScript<RegionRow>
    {
    }
}