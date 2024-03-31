import { IEmployeeUser } from "./Master/IEmployeeUser";

export interface IEmployeeAttendance {
    employee_AttendanceId: number;
    employee?: number | null ;
    date: Date;
    attendance_Type: string;
}
