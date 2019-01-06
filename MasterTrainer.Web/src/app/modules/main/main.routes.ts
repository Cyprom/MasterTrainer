import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { InstructionsComponent } from './components/instructions/instructions.component';

export const mainRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'instructions', component: InstructionsComponent }
];