
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Shipper")]
    public class ShipperLookup : MultiTenantRowLookupScript<ShipperRow>
    {
    }
}