import {IUser} from "../models/users/IUser";
import { Component, Input } from "@angular/core";
import { NgbActiveModal } from "@ng-bootstrap/ng-bootstrap";
import { IVacationDays } from "../models/vacationDays/IVacationDays";
import { VacationDaysService } from "./vacationDays.service";

@Component({
    selector: 'vacation-days-details',
    templateUrl: "../../partials/vacationDays/vacationDaysDetails-component.html",
})
export class VacationDaysDetailsComponent {

    @Input() vacationDays:IVacationDays;
    


    constructor(public activeModal: NgbActiveModal,public vacationDaysService:VacationDaysService ) {
        
    }

    close() {
        this.activeModal.close();
    }

    cancel() {
        this.activeModal.dismiss();
    }
}