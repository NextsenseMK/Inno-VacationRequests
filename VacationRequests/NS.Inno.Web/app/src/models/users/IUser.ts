export interface IUser {
    Id: number;
    Username: string;
    DisplayName: string;
    Active: boolean;
    EmploymentDate: Date;
}

export class User implements IUser {
    Id: number;
    Username: string;
    DisplayName: string;
    Active: boolean;
    EmploymentDate: Date;
    constructor() {

        this.Id = 0;
        this.Username = "";
        this.DisplayName = "";
        this.Active = false;
        this.EmploymentDate = null;
    }

}