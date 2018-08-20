import { Pipe, PipeTransform } from "@angular/core";
import {UserRoleEnum} from "../enums/UserRoleEnum";

@Pipe({ name: 'jsonDateFilter' })
export class JsonDateFilter implements PipeTransform {
    transform(value: any): any {
        debugger;
        var re = /\/Date\(([0-9]*)\)\//;
        var m = value.match(re);
        if (m) return new Date(parseInt(m[1]));
        else return null;
    }
}

@Pipe({ name: 'userRoleFilter' })
export class UserRoleFilter implements PipeTransform {
    transform(value: UserRoleEnum): any {
        return UserRoleEnum[value];
    }
}