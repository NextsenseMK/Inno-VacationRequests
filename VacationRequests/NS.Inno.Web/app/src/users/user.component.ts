import { Component } from '@angular/core';
import {IUser,User} from "../models/users/IUser";
import {UserService} from "./user.service";
import { NgbModal } from '@ng-bootstrap/ng-bootstrap';
import { AddEditDetailsUserComponent } from './addEditDetailsUser.component';
import { AddEditDetailsModeEnum } from '../enums/AddEditDetailsModeEnum';
import { VacationDaysDetailsComponent } from '../vacationDays/vacationDaysDetails.component';
import { VacationDaysService } from '../vacationDays/vacationDays.service';


@Component({
    selector: 'users',
    templateUrl: "../../partials/users/user-component.html",
})
export class UserComponent {

    users: IUser[];

    constructor(private userService: UserService, private modalService: NgbModal, private vacationDaysService:VacationDaysService) {
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

    seeUserVacationDays(user: IUser) {
        this.vacationDaysService.getUserVacationDays(user.Id)
            .subscribe((result) => {
                const modalRef = this.modalService.open(VacationDaysDetailsComponent);
                modalRef.componentInstance.vacationDays = result;
                },
                (error) => { });
       
    }
}