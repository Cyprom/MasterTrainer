import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

// Components
import { NavigationComponent } from './components/navigation/navigation.component';

@NgModule({
    declarations: [
        NavigationComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        HttpClientModule
    ],
    exports: [
        NavigationComponent
    ],
    providers: []
})

export class NavigationModule { }