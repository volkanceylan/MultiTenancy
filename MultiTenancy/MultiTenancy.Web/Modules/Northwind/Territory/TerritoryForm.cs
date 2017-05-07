
namespace MultiTenancy.Northwind.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Northwind.Territory")]
    [BasedOnRow(typeof(Entities.TerritoryRow))]
    public class TerritoryForm
    {
        public String TerritoryID { get; set; }
        public String TerritoryDescription { get; set; }
        [LookupEditor("Northwind.Region")]
        public Int32 RegionID { get; set; }
    }
}