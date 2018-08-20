import { Component } from '@angular/core';
import {ITeam} from "../models/teams/ITeam";
import { TeamService } from './team.service';


@Component({
    selector: 'teams',
    templateUrl: "../../partials/teams/team-component.html",
})
export class TeamComponent {

    teams: ITeam[];

    constructor(private teamService: TeamService) {
        this.getTeams();
    }

    getTeams() {
        this.teamService.getTeams()
            .subscribe((teams: ITeam[]) => {
                this.teams = teams;
            });
    }
}