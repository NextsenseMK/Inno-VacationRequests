import Team = require("../teams/ITeam");
import ITeam = Team.ITeam;
import {UserRoleEnum} from "../../enums/UserRoleEnum";

export interface IUser {
    Id: number;
    UserName: string;
    DisplayName: string;
    Active: boolean;
    EmploymentDate: Date;
    Team: ITeam;
    Role: UserRoleEnum;
}

export class User implements IUser {
    Id: number;
    UserName: string;
    DisplayName: string;
    Active: boolean;
    EmploymentDate: Date;
    Team: ITeam;
    Role:UserRoleEnum;
    constructor() {

        this.Id = 0;
        this.UserName = "";
        this.DisplayName = "";
        this.Active = false;
        this.EmploymentDate = null;
        this.Team = null;
    }

}