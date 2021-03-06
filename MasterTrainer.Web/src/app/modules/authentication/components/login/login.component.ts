﻿import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationApiService } from '../../../shared/services/authentication-api.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styles: [':host { width: 100%; }']
})
export class LoginComponent implements OnInit {

    public isBusy: boolean;

    constructor(
        private router: Router,
        private authenticationApi: AuthenticationApiService
    ) {
        const authenticationSubscription = this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                this.router.navigate(['dashboard']);
            }
            authenticationSubscription.unsubscribe();
        });
    }

    public ngOnInit = () => { }

    public login = (name: string, password: string) => {
        if (!this.isBusy) {
            this.isBusy = true;

            this.authenticationApi.logIn(name, password).subscribe(user => {
                this.router.navigate(['dashboard']);
                this.isBusy = false;
            }, error => {
                this.isBusy = false;
            });
        }
    }
}