import { IEmployeeUser } from "./Master/IEmployeeUser";

export interface EmployeeAttendance {
    employeeAttendanceId: number;
    employee: IEmployeeUser;
    date: Date;
    attendanceType: string;
}
