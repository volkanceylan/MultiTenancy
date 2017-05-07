
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Category")]
    public class CategoryLookup : MultiTenantRowLookupScript<CategoryRow>
    {
    }
}