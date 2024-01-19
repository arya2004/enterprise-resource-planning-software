import { IEmployeeUser } from "./Master/IEmployeeUser";
import { IProject } from "./Master/IProject";

export interface OwnCarLocalAndOutStation {
    ownCarLocalAndOutStationId: number;
    project?: IProject | null;
    employee?: IEmployeeUser | null;
    petrolRate: number;
    carAvgKMPL: number;
    distanceTravelled: number;
    costOfTravel: number;
    publicTransport?: number | null;
    drawingPrints?: number | null;
    courier?: number | null;
    toll?: number | null;
}
