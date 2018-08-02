import { IUser } from "../users/IUser";

export interface IVacationRequest {
         Id:number;
         DateFrom:Date;
         DateTo:Date;
         Days:number;
         Description: string;
         Year:number;
         User:IUser;
         CreatedOn: Date;
         ModifiedOn:Date;
         ModifiedBy:IUser;
         CreatedBy:IUser;
}

export class VacationRequest implements IVacationRequest {
    Id: number;
    DateFrom: Date;
    DateTo: Date;
    Days: number;
    Description: string;
    Year: number;
    User: IUser;
    CreatedOn: Date;
    ModifiedOn: Date;
    ModifiedBy: IUser;
    CreatedBy: IUser;

    constructor() {
        this.Id = 0;
        this.DateFrom = null;
        this.DateTo = null;
        this.CreatedOn = null;
        this.ModifiedOn = null;
        this.CreatedBy = null;
        this.ModifiedBy = null;
        this.Description = "";
        this.Year = 0;
        this.Days = 0;
    }
}