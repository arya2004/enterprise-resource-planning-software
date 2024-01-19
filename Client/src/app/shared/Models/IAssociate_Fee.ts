import { IAssociateUser } from "./Master/IAssociateUser";

export interface AssociateFee {
    associateFeeId: number;
    associate: IAssociateUser;
    projectFee: number;
    transactionDate: Date;
    transactionType: string;
    amount: number;
    tdsAmount: number;
    igst: number;
    sgst: number;
    cgst: number;
    netAmount: number;
}
