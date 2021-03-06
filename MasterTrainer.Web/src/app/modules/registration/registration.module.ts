﻿import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { NavigationModule } from '../navigation/navigation.module';
import { SharedModule } from '../shared/shared.module';

// Components
import { RegistrationComponent } from './components/registration/registration.component';

// Services
import { RegistrationApiService } from './services/registration-api.service';

@NgModule({
    declarations: [
        RegistrationComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        HttpClientModule,
        NavigationModule,
        SharedModule
    ],
    exports: [],
    providers: [
        RegistrationApiService
    ]
})

export class RegistrationModule { }