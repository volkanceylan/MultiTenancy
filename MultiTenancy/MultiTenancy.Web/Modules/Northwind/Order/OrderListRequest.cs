using Serenity.Services;

namespace MultiTenancy.Northwind
{
    public class OrderListRequest : ListRequest
    {
        public int? ProductID { get; set; }
    }
}