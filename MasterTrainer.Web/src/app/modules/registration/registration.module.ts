import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

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
        HttpClientModule
    ],
    exports: [],
    providers: [
        RegistrationApiService
    ]
})

export class RegistrationModule { }