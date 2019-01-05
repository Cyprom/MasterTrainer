import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

// Components
import { HomeComponent } from './components/home/home.component';

// Services

@NgModule({
    declarations: [
        HomeComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        HttpClientModule
    ],
    exports: [],
    providers: []
})

export class MainModule { }