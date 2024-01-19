import { IAssociateUser } from "./Master/IAssociateUser";
import { IProject } from "./Master/IProject";

export interface IAssociateWorkerOrders {
    associateWorkerOrdersId: number;
    project?: IProject | null;
    associateUser?: IAssociateUser | null;
    workOrderNumber?: string | null;
    woAmount?: number | null;
    service?: string | null;
    woDate?: Date | null;
    woStatus?: string | null;
}
