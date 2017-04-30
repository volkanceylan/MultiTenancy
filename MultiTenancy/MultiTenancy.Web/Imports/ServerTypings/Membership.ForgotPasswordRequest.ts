namespace MultiTenancy.Membership {
    export interface ForgotPasswordRequest extends Serenity.ServiceRequest {
        Email?: string;
    }
}

