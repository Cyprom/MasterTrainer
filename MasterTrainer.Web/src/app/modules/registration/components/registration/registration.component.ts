import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { RegistrationApiService } from '../../services/registration-api.service';

@Component({
    selector: 'app-registration',
    templateUrl: './registration.component.html',
    styles: [':host { width: 100%; }']
})
export class RegistrationComponent implements OnInit {

    public isBusy: boolean;

    constructor(
        private router: Router,
        private registrationApi: RegistrationApiService
    ) { }

    public ngOnInit = () => { }

    public register = (name: string, password: string, confirmation: string) => {
        if (!this.isBusy) {
            this.isBusy = true;

            this.registrationApi.register(name, password, confirmation).subscribe(user => {
                this.router.navigate(['home']);
                this.isBusy = false;
            }, error => {
                this.isBusy = false;
            });
        }
    }
}