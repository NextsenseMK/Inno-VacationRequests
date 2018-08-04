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
        AppComponent, UserComponent, TeamComponent, JsonDateFilter, UserRoleFilter
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        RouterModule.forRoot(
            appRoutes, { useHash: true }
        )
    ],
    providers: [UserService],
    bootstrap: [AppComponent]
})
export class AppModule { }