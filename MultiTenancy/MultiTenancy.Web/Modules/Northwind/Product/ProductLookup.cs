
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Product")]
    public class ProductLookup : MultiTenantRowLookupScript<ProductRow>
    {
    }
}