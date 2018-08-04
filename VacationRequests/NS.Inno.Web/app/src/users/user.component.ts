import { Component } from '@angular/core';
import {IUser} from "../models/users/IUser";
import {UserService} from "./user.service";


@Component({
    selector: 'users',
    templateUrl: "../../partials/users/user-component.html",
})
export class UserComponent {

    users: IUser[];

    constructor(private userService: UserService) {
        this.getUsers();
    }

    getUsers() {
        this.userService.getUsers()
            .subscribe((users: IUser[]) => {
                this.users = users;
            });
    }
}