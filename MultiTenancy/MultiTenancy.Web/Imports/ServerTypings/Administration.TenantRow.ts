
namespace MultiTenancy.Administration {
    export interface TenantRow {
        TenantId?: number;
        TenantName?: string;
    }

    export namespace TenantRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'TenantName';
        export const localTextPrefix = 'Administration.Tenant';

        export namespace Fields {
            export declare const TenantId;
            export declare const TenantName;
        }

        ['TenantId', 'TenantName'].forEach(x => (<any>Fields)[x] = x);
    }
}

