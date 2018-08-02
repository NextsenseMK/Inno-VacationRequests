import { IVacationRequest } from "../vacationRequests/IVacationRequest";
import { IUser } from "../users/IUser";

export interface IApprovingLevel {
    Id: number;
    VacationRequest: IVacationRequest;
    Level: number;
    CreatedOn: Date;
    ActionOn: Date;
    Status: string;
    CreatedBy: IUser;

}

export class ApprovingLevel implements IApprovingLevel {
    Id: number;
    VacationRequest: IVacationRequest;
    Level: number;
    CreatedOn: Date;
    ActionOn: Date;
    Status: string;
    CreatedBy: IUser;

    constructor() {
        this.Id = 0;
        this.VacationRequest = null;
        this.Level = 0;
        this.CreatedBy = null;
        this.CreatedOn = null;
        this.Status = "";
    }
}