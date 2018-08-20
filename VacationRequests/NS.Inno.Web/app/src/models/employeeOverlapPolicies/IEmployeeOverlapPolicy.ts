import { IUser } from "../users/IUser";

export interface IEmployeeOverlapPolicy {
    Id: number;
    User1: IUser;
    User2: IUser;
    Active: boolean;

}

export class EmployeeOverlapPolicy implements IEmployeeOverlapPolicy {
    Id: number;
    User1: IUser;
    User2: IUser;
    Active: boolean;

    constructor() {
        this.Id = 0;
        this.User1 = null;
        this.User2 = null;
        this.Active = false;
    }
}