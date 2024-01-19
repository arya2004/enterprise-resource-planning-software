import { IProject } from "./Master/IProject";

export interface ProformaInvoice {
    proformaInvoiceId: number;
    project: IProject;
    invoiceDate: Date;
    invoiceNumber: string;
    amount: number;
    igst: number;
    sgst: number;
    cgst: number;
    netAmount: number;
    gstInvoiceStatus: string;
    gstInvoiceDate: Date;
    gstInvoiceNumber: string;
}
