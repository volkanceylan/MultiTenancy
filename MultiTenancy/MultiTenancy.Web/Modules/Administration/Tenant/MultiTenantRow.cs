using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;

namespace MultiTenancy
{
    public abstract class MultiTenantRow : Row, IMultiTenantRow
    {
        protected MultiTenantRow(RowFieldsBase fields)
            : base(fields)
        {
            multiTenantFields = (MultiTenantFields)fields;
        }

        [NotNull, Insertable(false), Updatable(false)]
        public Int32? TenantId
        {
            get { return multiTenantFields.TenantId[this]; }
            set { multiTenantFields.TenantId[this] = value; }
        }

        Int32Field IMultiTenantRow.TenantIdField
        {
            get { return multiTenantFields.TenantId; }
        }

        private MultiTenantFields multiTenantFields;

        public class MultiTenantFields : RowFieldsBase
        {
            public Int32Field TenantId;

            public MultiTenantFields(string tableName = null, string fieldPrefix = null)
                : base(tableName, fieldPrefix)
            {
            }
        }
    }
}