import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthenticationApiService } from '../../services/authentication-api.service';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html'
})
export class LoginComponent implements OnInit {

    public isBusy: boolean;

    constructor(
        private router: Router,
        private authenticationApi: AuthenticationApiService
    ) {
        const authenicationSubscription = this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                this.router.navigate(['dashboard']);
                authenicationSubscription.unsubscribe();
            }
        })
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