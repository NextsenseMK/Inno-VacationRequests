﻿import { Component } from '@angular/core';
import {IUser,User} from "../models/users/IUser";
import {UserService} from "./user.service";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AddEditDetailsUserComponent } from './addEditDetailsUser.component';
import { AddEditDetailsModeEnum } from '../enums/AddEditDetailsModeEnum';


@Component({
    selector: 'users',
    templateUrl: "../../partials/users/user-component.html",
})
export class UserComponent {

    users: IUser[];

    constructor(private userService: UserService, private modalService: NgbModal) {
        this.getUsers();
    }

    getUsers() {
        this.userService.getUsers()
            .subscribe((users: IUser[]) => {
                this.users = users;
            });
    }

    addUser() {
        const modalRef = this.modalService.open(AddEditDetailsUserComponent);
        modalRef.componentInstance.mode = AddEditDetailsModeEnum.Add;
        modalRef.componentInstance.user = new User();
        modalRef.result.then((result) => {
             this.users.push(result.user);
        });
    }
}