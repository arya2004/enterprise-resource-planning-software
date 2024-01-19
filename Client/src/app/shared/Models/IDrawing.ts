import { IDrawingRevision } from "./IDrawingRevision";
import { IArchitect } from "./Master/IArchitect";
import { IClient } from "./Master/IClient";
import { ICompany } from "./Master/ICompany";
import { IEmployeeUser } from "./Master/IEmployeeUser";
import { IProject } from "./Master/IProject";

export interface Drawing {
    drawingId: number;
    project?: IProject | null;
    company?: ICompany | null;
    employee?: IEmployeeUser | null;
    client?: IClient | null;
    architect?: IArchitect | null;
    drawingNumber: number;
    drawingRevisions?: IDrawingRevision[] | null;
}

