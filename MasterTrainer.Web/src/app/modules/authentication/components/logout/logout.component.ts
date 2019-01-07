﻿import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationApiService } from '../../../shared/services/authentication-api.service';

@Component({
    selector: 'app-logout',
    templateUrl: './logout.component.html'
})
export class LogoutComponent implements OnInit {

    public isBusy: boolean;
    public isLoggedIn: boolean;

    constructor(
        private router: Router,
        private authenticationApi: AuthenticationApiService
    ) {
        const authenticationSubscription = this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                this.isLoggedIn = true;
            }
            authenticationSubscription.unsubscribe();
        });
    }

    public ngOnInit = () => { }

    public logOut = () => {
        if (!this.isBusy) {
            this.isBusy = true;

            this.authenticationApi.logOut().subscribe(user => {
                this.router.navigate(['home']);
                this.isBusy = false;
            }, error => {
                this.isBusy = false;
            });
        }
    }
}