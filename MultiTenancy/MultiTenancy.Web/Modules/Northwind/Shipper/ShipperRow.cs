
namespace MultiTenancy.Northwind.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("Northwind"), TableName("Shippers"), DisplayName("Shippers"), InstanceName("Shipper"), TwoLevelCached]
    [ReadPermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]
    public sealed class ShipperRow : Row, IIdRow, INameRow, IMultiTenantRow
    {
        [DisplayName("Shipper Id"), Identity]
        public Int32? ShipperID
        {
            get { return Fields.ShipperID[this]; }
            set { Fields.ShipperID[this] = value; }
        }

        [DisplayName("Company Name"), Size(40), NotNull, QuickSearch]
        public String CompanyName
        {
            get { return Fields.CompanyName[this]; }
            set { Fields.CompanyName[this] = value; }
        }

        [DisplayName("Phone"), Size(24)]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        [Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return Fields.TenantId[this]; }
            set { Fields.TenantId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.ShipperID; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CompanyName; }
        }

        public Int32Field TenantIdField
        {
            get { return Fields.TenantId; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ShipperRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field ShipperID;
            public StringField CompanyName;
            public StringField Phone;
            public Int32Field TenantId;

            public RowFields()
            {
                LocalTextPrefix = "Northwind.Shipper";
            }
        }
    }
}