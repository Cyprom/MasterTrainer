import { Routes } from '@angular/router';

import { HomeComponent } from './components/home/home.component';
import { InstructionsComponent } from './components/instructions/instructions.component';
import { AboutComponent } from './components/about/about.component';

export const mainRoutes: Routes = [
    { path: 'home', component: HomeComponent },
    { path: 'instructions', component: InstructionsComponent },
    { path: 'about', component: AboutComponent }
];