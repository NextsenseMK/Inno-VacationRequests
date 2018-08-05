import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './users/user.component';
import { TeamComponent } from './teams/team.component';
import {UserService} from "./users/user.service";
import { JsonDateFilter, UserRoleFilter } from './common/filters';
import {TeamService} from "./teams/team.service";
import { AddEditDetailsUserComponent } from './users/addEditDetailsUser.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

const appRoutes: Routes = [
    { path: 'users', component: UserComponent },
    { path: 'teams', component: TeamComponent },

    {
        path: '',
        redirectTo: '/users',
        pathMatch: 'full'
    }
];

// @NgModule decorator with its metadata
@NgModule({
    declarations: [
        AppComponent, UserComponent, TeamComponent, JsonDateFilter, UserRoleFilter,AddEditDetailsUserComponent
    ],
    entryComponents: [AddEditDetailsUserComponent],
    imports: [
        BrowserModule,
        HttpClientModule,
        RouterModule.forRoot(
            appRoutes, { useHash: true }
        ),
        NgbModule.forRoot(),
        FormsModule
    ],
    providers: [UserService,TeamService],
    bootstrap: [AppComponent]
})
export class AppModule { }