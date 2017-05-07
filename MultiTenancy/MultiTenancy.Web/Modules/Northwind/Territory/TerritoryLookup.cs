
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Territory")]
    public class TerritoryLookup : MultiTenantRowLookupScript<TerritoryRow>
    {
    }
}