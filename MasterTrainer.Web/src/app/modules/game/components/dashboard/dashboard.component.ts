﻿import { Component, OnInit } from '@angular/core';
import { User } from '../../../shared/models/user.model';
import { AuthenticationApiService } from '../../../shared/services/authentication-api.service';

@Component({
    selector: 'app-dashboard',
    templateUrl: './dashboard.component.html',
    styles: [':host { width: 100%; }']
})
export class DashboardComponent implements OnInit {

    public isBusy: boolean;
    public user: User;

    constructor(
        private authenticationApi: AuthenticationApiService
    ) {
        const authenticationSubscription = this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                this.user = user;
            }
            authenticationSubscription.unsubscribe();
        });
    }

    public ngOnInit = () => { }

    public newGame = () => {
        if (!this.isBusy) {
            this.isBusy = true;
            console.log('Start a new game');
            this.isBusy = false;
        }
    }
}