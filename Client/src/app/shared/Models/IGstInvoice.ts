import { IProject } from "./Master/IProject";

export interface GSTInvoice {
    gstInvoiceId: number;
    project: IProject;
    invoiceDate: Date;
    invoiceNumber: string;
    amount: number;
    igst: number;
    sgst: number;
    cgst: number;
    netAmount: number;
}
