import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient } from "@angular/common/http";
import { GlobalVariables } from "../common/globalVariables";
import {IVacationDays} from "../models/vacationDays/IVacationDays";


@Injectable()
export class VacationDaysService {
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Accept': 'application/json',
            'Authorization': 'my-auth-token'
        })
    };
    constructor(private http: HttpClient) { }

    getUserVacationDays(userId: number) {
        var obj = { userId: userId };
        var data = JSON.stringify(obj);
        return this.http.post<IVacationDays>(GlobalVariables.baseurl + "VacationDays/GetUserVacationDays",
            data,this.httpOptions);
    }




}