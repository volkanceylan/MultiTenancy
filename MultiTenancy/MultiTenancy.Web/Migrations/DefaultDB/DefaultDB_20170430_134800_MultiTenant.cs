using FluentMigrator;

namespace MultiTenancy.Migrations.DefaultDB
{
    [Migration(20170430134800)]
    public class DefaultDB_20170430_134800_MultiTenant : AutoReversingMigration
    {
        public override void Up()
        {
            this.CreateTableWithId32("Tenants", "TenantId", s => s
                .WithColumn("TenantId").AsInt32().Identity().PrimaryKey().NotNullable()
                .WithColumn("TenantName").AsString(100).NotNullable());

            Insert.IntoTable("Tenants").Row(new
            {
                TenantName = "Primary Tenant"
            });

            Insert.IntoTable("Tenants").Row(new
            {
                TenantName = "Second Tenant"
            });

            Insert.IntoTable("Tenants").Row(new
            {
                TenantName = "Third Tenant"
            });

            Alter.Table("Users")
                .AddColumn("TenantId").AsInt32().NotNullable().WithDefaultValue(1);

            Alter.Table("Roles")
                .AddColumn("TenantId").AsInt32().NotNullable().WithDefaultValue(1);

            Alter.Table("Languages")
                .AddColumn("TenantId").AsInt32().NotNullable().WithDefaultValue(1);
        }
    }
}