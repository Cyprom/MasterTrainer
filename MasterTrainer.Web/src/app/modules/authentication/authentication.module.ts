﻿import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { NavigationModule } from '../navigation/navigation.module';
import { SharedModule } from '../shared/shared.module';

// Components
import { LoginComponent } from './components/login/login.component';
import { LogoutComponent } from './components/logout/logout.component';
import { ChangePasswordComponent } from './components/change-password/change-password.component';

@NgModule({
    declarations: [
        LoginComponent,
        LogoutComponent,
        ChangePasswordComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        HttpClientModule,
        NavigationModule,
        SharedModule
    ],
    exports: [
        LogoutComponent,
        ChangePasswordComponent
    ],
    providers: []
})

export class AuthenticationModule { }