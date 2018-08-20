import { IUser } from "../users/IUser";

export interface IVacationDays {
    Id: number;
    UsedDays: number;
    TotalDays: number;
    User: IUser;
}

export class VacationDays implements IVacationDays {
    Id: number;
    UsedDays: number;
    TotalDays: number;
    User: IUser;

    constructor() {
        this.Id = 0;
        this.UsedDays = 0;
        this.TotalDays = 0;
        this.User = null;
    }
}