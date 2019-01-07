import { Component, OnInit } from '@angular/core';
import { AuthenticationApiService } from '../../../shared/services/authentication-api.service';

@Component({
    selector: 'app-change-password',
    templateUrl: './change-password.component.html'
})
export class ChangePasswordComponent implements OnInit {

    public isBusy: boolean;
    public isLoggedIn: boolean;

    constructor(
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

    public changePassword = () => {
        if (!this.isBusy) {
            this.isBusy = true;

            //this.authenticationApi.logOut().subscribe(user => {
            //    this.router.navigate(['home']);
            //    this.isBusy = false;
            //}, error => {
            //    this.isBusy = false;
            //});

            console.log('Change password through modal with API call');
            this.isBusy = false;
        }
    }
}