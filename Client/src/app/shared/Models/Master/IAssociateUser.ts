export interface IAssociateUser {
   
    userName?: string | null; // IdentityUser UserName
    normalizedUserName?: string | null; // IdentityUser NormalizedUserName
    email?: string | null; // IdentityUser Email
    normalizedEmail?: string | null; // IdentityUser NormalizedEmail
    emailConfirmed?: boolean | null; // IdentityUser EmailConfirmed
    passwordHash?: string | null; // IdentityUser PasswordHash
    securityStamp?: string | null; // IdentityUser SecurityStamp
    concurrencyStamp?: string | null; // IdentityUser ConcurrencyStamp
    phoneNumber?: string | null; // IdentityUser PhoneNumber
    phoneNumberConfirmed?: boolean | null; // IdentityUser PhoneNumberConfirmed
    twoFactorEnabled?: boolean | null; // IdentityUser TwoFactorEnabled
    lockoutEnd?: Date | null; // IdentityUser LockoutEnd
    lockoutEnabled?: boolean | null; // IdentityUser LockoutEnabled
    accessFailedCount?: number | null; // IdentityUser AccessFailedCount

    companyName?: string | null;
    addressLine1?: string | null;
    addressLine2?: string | null;
    addressLine3?: string | null;
    city?: string | null;
    state?: string | null;
    country?: string | null;
    postalCode?: number;
    contactPerson1?: string | null;
    designation1?: string | null;
    mobileNumber1?: number;
    email1?: string | null;
    contactPerson2?: string | null;
    designation2?: string | null;
    mobileNumber2?: number;
    email2?: string | null;
    panNumber?: string | null;
    gstNumber?: string | null;
    bank?: string | null;
    branchName?: string | null;
    branchAddress?: string | null;
    accountNumber?: number;
    isfCode?: string | null;
    accountType?: number;
    isFreeLancer?: boolean;
}
