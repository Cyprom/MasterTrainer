import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { AuthenticationApiService } from '../../../shared/services/authentication-api.service';

@Component({
    selector: 'app-navigation',
    templateUrl: './navigation.component.html'
})
export class NavigationComponent implements OnInit {

    public isAuthenticated: boolean;

    constructor(
        private activatedRoute: ActivatedRoute,
        private authenticationApi: AuthenticationApiService
    ) {
        this.activatedRoute.params.subscribe(() => { });
        const authenticationSubscription = this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                this.isAuthenticated = true;
            }
            authenticationSubscription.unsubscribe();
        });
    }

    public ngOnInit = () => { }
}