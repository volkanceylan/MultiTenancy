

namespace MultiTenancy.Administration.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System.Data;
    using MyRow = Entities.RoleRow;

    public class RoleRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            protected override void SetInternalFields()
            {
                base.SetInternalFields();

                if (IsCreate)
                    Row.TenantId = ((UserDefinition)Authorization.UserDefinition).TenantId;
            }

            protected override void ValidateRequest()
            {
                base.ValidateRequest();

                if (IsUpdate)
                {
                    var user = (UserDefinition)Authorization.UserDefinition;
                    if (Old.TenantId != user.TenantId)
                        Authorization.ValidatePermission(PermissionKeys.Tenants);
                }
            }
        }

        private class MyDeleteHandler : DeleteRequestHandler<MyRow>
        {
            protected override void ValidateRequest()
            {
                base.ValidateRequest();

                var user = (UserDefinition)Authorization.UserDefinition;
                if (Row.TenantId != user.TenantId)
                    Authorization.ValidatePermission(PermissionKeys.Tenants);
            }
        }

        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
        {
            protected override void PrepareQuery(SqlQuery query)
            {
                base.PrepareQuery(query);

                var user = (UserDefinition)Authorization.UserDefinition;
                if (!Authorization.HasPermission(PermissionKeys.Tenants))
                    query.Where(fld.TenantId == user.TenantId);
            }
        }

        private class MyListHandler : ListRequestHandler<MyRow>
        {
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);

                var user = (UserDefinition)Authorization.UserDefinition;
                if (!Authorization.HasPermission(PermissionKeys.Tenants))
                    query.Where(fld.TenantId == user.TenantId);
            }
        }
    }
}