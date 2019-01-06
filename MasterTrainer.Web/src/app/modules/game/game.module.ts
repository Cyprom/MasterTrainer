import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { AuthenticationModule } from '../authentication/authentication.module';
import { NavigationModule } from '../navigation/navigation.module';
import { SharedModule } from '../shared/shared.module';

// Components
import { DashboardComponent } from './components/dashboard/dashboard.component';

// Services

@NgModule({
    declarations: [
        DashboardComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        HttpClientModule,
        AuthenticationModule,
        NavigationModule,
        SharedModule
    ],
    exports: [],
    providers: []
})

export class GameModule { }