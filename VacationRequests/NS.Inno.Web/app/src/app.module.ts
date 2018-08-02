import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { Routes, RouterModule } from '@angular/router';
import { UserComponent } from './users/user.component';

const appRoutes: Routes = [
    { path: 'users', component: UserComponent },

    {
        path: '',
        redirectTo: '/users',
        pathMatch: 'full'
    }
];

// @NgModule decorator with its metadata
@NgModule({
    declarations: [
        AppComponent, UserComponent
    ],
    imports: [
        BrowserModule,
        FormsModule,
        HttpClientModule,
        RouterModule.forRoot(
            appRoutes, { useHash: true }
        )
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }