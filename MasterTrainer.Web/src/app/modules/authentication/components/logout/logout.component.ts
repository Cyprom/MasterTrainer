import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationApiService } from '../../services/authentication-api.service';

@Component({
    selector: 'app-logout',
    templateUrl: './logout.component.html'
})
export class LogoutComponent implements OnInit {

    public isBusy: boolean;
    public isHidden: boolean;

    constructor(
        private router: Router,
        private authenticationApi: AuthenticationApiService
    ) {
        this.isHidden = true;
        const authenicationSubscription = this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                this.isHidden = false;
            }
            authenicationSubscription.unsubscribe();
        });
    }

    public ngOnInit = () => { }

    public logout = () => {
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