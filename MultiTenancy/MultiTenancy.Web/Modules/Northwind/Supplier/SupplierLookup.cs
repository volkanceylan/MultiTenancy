
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Supplier")]
    public class SupplierLookup : MultiTenantRowLookupScript<SupplierRow>
    {
    }
}