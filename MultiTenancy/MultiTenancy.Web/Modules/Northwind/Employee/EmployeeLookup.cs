
namespace MultiTenancy.Northwind.Scripts
{
    using Entities;
    using Serenity.ComponentModel;
    using Serenity.Web;

    [LookupScript("Northwind.Employee")]
    public class EmployeeLookup : MultiTenantRowLookupScript<EmployeeRow>
    {
    }
}