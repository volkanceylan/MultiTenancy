
namespace MultiTenancy.Administration {
    
    @Serenity.Decorators.registerClass()
    export class TenantGrid extends Serenity.EntityGrid<TenantRow, any> {
        protected getColumnsKey() { return 'Administration.Tenant'; }
        protected getDialogType() { return TenantDialog; }
        protected getIdProperty() { return TenantRow.idProperty; }
        protected getLocalTextPrefix() { return TenantRow.localTextPrefix; }
        protected getService() { return TenantService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}