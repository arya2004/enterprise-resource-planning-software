import { IProject } from "./Master/IProject";

interface ProjectFees {
    projectFeesId: number;
    project?: IProject | null;
    trxDate: Date;
    valueDate: Date;
    trxNo?: string | null;
    amount: number;
    tdsAmount: number;
    igst: number;
    sgst: number;
    cgst: number;
    netAmount: number;
}
