import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Subject } from 'rxjs/Subject';

import { User } from '../models/user.model';

@Injectable()
export class AuthenticationApiService {

    private apiPath = 'api/v1/authentication';

    private userSubject = new Subject<User>();

    constructor(
        private http: HttpClient
    ) { }

    public logIn = (name: string, password: string) => {
        return this.http.post<User>(this.apiPath + '/log-in', { name: name, password: password });
    }

    public isLoggedIn = () => {
        this.http.get<User>(this.apiPath + '/is-logged-in').subscribe(user => {
            this.userSubject.next(user);
        }, error => {
            this.userSubject.next(undefined);
        });
        return this.userSubject.asObservable();
    }

    public logOut = () => {
        return this.http.delete(this.apiPath + '/log-out');
    }
}