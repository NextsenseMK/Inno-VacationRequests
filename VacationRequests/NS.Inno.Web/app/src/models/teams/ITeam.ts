import {IUser} from "../users/IUser";

export interface ITeam {
    Id: number;
    Name: string;
    Active: boolean;
    TeamLeaders:IUser[];
}


export class Team implements ITeam {
    Id: number;
    Name: string;
    Active: boolean;
    TeamLeaders: IUser[];

    constructor() {
        this.Id = 0;
        this.Name = "";
        this.Active = false;
        this.TeamLeaders = [];
    }
}