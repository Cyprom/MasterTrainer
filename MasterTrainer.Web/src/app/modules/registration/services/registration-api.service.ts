import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../../shared/models/user.model';

@Injectable()
export class RegistrationApiService {

    private apiPath = 'api/v1/registration';

    constructor(
        private http: HttpClient
    ) { }

    public register = (name: string, password: string, confirmation: string) => {
        return this.http.post<User>(this.apiPath + '/register', { name: name, password: password, confirmation: confirmation });
    }
}