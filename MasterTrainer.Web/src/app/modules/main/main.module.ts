import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';
import { NavigationModule } from '../navigation/navigation.module';
import { SharedModule } from '../shared/shared.module';

// Components
import { HomeComponent } from './components/home/home.component';

@NgModule({
    declarations: [
        HomeComponent
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
    providers: []
})

export class MainModule { }