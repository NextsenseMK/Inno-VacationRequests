export interface ITeam {
    Id: number;
    Name: string;
    Active: boolean;
}


export class Team implements ITeam {
    Id: number;
    Name: string;
    Active: boolean;

    constructor() {
        this.Id = 0;
        this.Name = "";
        this.Active = false;
    }
}