import { IEmployeeUser } from "./Master/IEmployeeUser";
import { IProject } from "./Master/IProject";

export interface IEmployeeTimeSheet {
    employeeTimeSheetId: number;
    employee?: IEmployeeUser | null;
    project?: IProject | null;
    workDate?: Date | null;
    workDescription: string;
    hoursSpent: number;
    ratePerHour: number;
    amount: number;
}
