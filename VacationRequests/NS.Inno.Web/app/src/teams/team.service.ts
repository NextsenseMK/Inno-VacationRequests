import {HttpHeaders} from "@angular/common/http";
import {HttpClient} from "@angular/common/http";
import {GlobalVariables} from "../common/globalVariables";
import {ITeam} from "../models/teams/ITeam";
import { Injectable } from "@angular/core";

@Injectable()
export class TeamService {
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Authorization': 'my-auth-token'
        })
    };
    constructor(private http: HttpClient) { }

    getTeams() {
        return this.http.get<ITeam[]>(GlobalVariables.baseurl + "Team/GetTeams");
    }


}