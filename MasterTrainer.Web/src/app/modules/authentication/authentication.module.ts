import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { NavigationModule } from '../navigation/navigation.module';
import { SharedModule } from '../shared/shared.module';

// Components
import { LoginComponent } from './components/login/login.component';
import { LogoutComponent } from './components/logout/logout.component';

// Services
import { AuthenticationApiService } from './services/authentication-api.service';

// Guard
import { AuthenticationGuard } from './guards/authentication.guard';

@NgModule({
    declarations: [
        LoginComponent,
        LogoutComponent
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
        LogoutComponent
    ],
    providers: [
        AuthenticationApiService,
        AuthenticationGuard
    ]
})

export class AuthenticationModule { }