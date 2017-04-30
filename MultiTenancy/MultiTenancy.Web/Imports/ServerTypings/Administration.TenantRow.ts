namespace MultiTenancy.Administration {
    export interface TenantRow {
        TenantId?: number;
        TenantName?: string;
    }

    export namespace TenantRow {
        export const idProperty = 'TenantId';
        export const nameProperty = 'TenantName';
        export const localTextPrefix = 'Administration.Tenant';
        export const lookupKey = 'Administration.Tenant';

        export function getLookup(): Q.Lookup<TenantRow> {
            return Q.getLookup<TenantRow>('Administration.Tenant');
        }

        export namespace Fields {
            export declare const TenantId: string;
            export declare const TenantName: string;
        }

        ['TenantId', 'TenantName'].forEach(x => (<any>Fields)[x] = x);
    }
}

