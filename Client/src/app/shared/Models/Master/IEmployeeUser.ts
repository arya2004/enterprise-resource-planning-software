export interface IEmployeeUser {
    id?: string; // IdentityUser ID
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

    employeeCode?: string | null;
    employeeName?: string | null;
    addressLine1?: string | null;
    addressLine2?: string | null;
    addressLine3?: string | null;
    city?: string | null;
    state?: string | null;
    country?: string | null;
    postalCode?: number;
    contactPerson1?: string | null;
    relation1?: string | null;
    mobileNumber1?: number;
    contactPerson2?: string | null;
    relation2?: string | null;
    mobileNumber2?: number;
    expBeforeJoiningY?: number;
    expBeforeJoiningM?: number;
    pan?: string | null;
    uid?: string | null;
    birthDate?: Date;
    anniversary?: Date;
    bankName?: string | null;
    branchName?: string | null;
    branchAddress?: string | null;
    accountNumber?: number;
    isfCode?: string | null;
    accountType?: string | null;
    monthlySalary?: number;
}
