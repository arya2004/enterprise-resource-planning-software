import { IArchitect } from "./IArchitect";
import { IAssociateUser } from "./IAssociateUser";
import { IClient } from "./IClient";
import { ICompany } from "./ICompany";
import { IEmployeeUser } from "./IEmployeeUser";

export interface IProject {
    projectId?: string; // You can make this optional based on your requirements
    company?: ICompany | null;
    employee?: IEmployeeUser | null;
    client?: IClient | null;
    architect?: IArchitect | null;
    associate?: IAssociateUser | null;
    projectCode?: number | null;
    name?: string | null;
    clientWoNumber?: string | null;
    start?: Date | null;
    end?: Date | null;
    services?: string | null;
    projectLocation?: string | null; // Corrected typo in property name
    totalFees?: number | null;
    feesReceived?: number | null;
    feesBalance?: number | null;
    expenses?: number | null;
    profitAmount?: number | null;
    isCompleted?: boolean | null;
}
