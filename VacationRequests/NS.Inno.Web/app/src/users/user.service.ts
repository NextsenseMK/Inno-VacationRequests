import { Injectable } from "@angular/core";
import { HttpHeaders, HttpClient } from "@angular/common/http";
import { IUser } from "../models/users/IUser";
import {GlobalVariables} from "../common/globalVariables";


@Injectable()
export class UserService {
    httpOptions = {
        headers: new HttpHeaders({
            'Content-Type': 'application/json',
            'Authorization': 'my-auth-token'
        })
    };
    constructor(private http: HttpClient) { }

    getUsers() {
        return this.http.get<IUser[]>(GlobalVariables.baseurl + "User/GetUsers");
    }

   
}