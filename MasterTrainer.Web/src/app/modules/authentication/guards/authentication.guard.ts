import { Injectable } from '@angular/core';
import { CanActivate, Router, ActivatedRouteSnapshot, RouterStateSnapshot } from '@angular/router';
import { Location } from '@angular/common';
import { Observable } from 'rxjs/Observable';
import { Subject } from 'rxjs/Subject';
import { AuthenticationApiService } from '../services/authentication-api.service';

@Injectable()
export class AuthenticationGuard implements CanActivate {

    constructor(
        private router: Router,
        private location: Location,
        private authenticationApi: AuthenticationApiService,
    ) { }

    public canActivate = (next: ActivatedRouteSnapshot, state: RouterStateSnapshot): Observable<boolean> | Promise<boolean> | boolean => {
        const subject = new Subject<boolean>();
        this.authenticationApi.isLoggedIn().subscribe(user => {
            if (user) {
                subject.next(true);
            } else {
                this.location.replaceState('/');
                this.router.navigate(['login']);
                subject.next(false);
            }
            subject.complete();
        })
        return subject.asObservable();
    }
}
