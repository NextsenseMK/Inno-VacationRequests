import { Component, Input } from "@angular/core";
import { IUser } from "../models/users/IUser";
import { UserService } from "./user.service";
import { NgbModal, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { AddEditDetailsModeEnum } from "../enums/AddEditDetailsModeEnum";
import { UserRoleEnum } from "../enums/UserRoleEnum";
import { TeamService } from "../teams/team.service";
import { ITeam } from "../models/teams/ITeam";

@Component({
    selector: 'add-edit-details-user',
    templateUrl: "../../partials/users/addEditDetailsUser-component.html",
})
export class AddEditDetailsUserComponent {

    @Input() user: IUser;
    @Input() mode: AddEditDetailsModeEnum;
    userRoleEnums: any[];
    teams:ITeam[];
   

    constructor(public activeModal: NgbActiveModal, private userService: UserService,private teamService:TeamService) {
        this.userRoleEnums = [];
        for (let i in UserRoleEnum) {
            if (this.isNumeric(i)) {
                var obj = {
                    Key: parseInt(i),
                    Value: UserRoleEnum[i]
                };
                this.userRoleEnums.push(obj);
            }
        }

        this.teamService.getTeams()
            .subscribe((teams: ITeam[]) => {
                this.teams = teams;
            });
    }

    isNumeric(num) {
        return !isNaN(num);
    }

    close() {
        this.activeModal.close({ user: this.user});
    }

    cancel() {
        this.activeModal.dismiss();
    }
}