import { Routes } from '@angular/router';

import { DashboardComponent } from './components/dashboard/dashboard.component';
import { AuthenticationGuard } from '../authentication/guards/authentication.guard';

export const gameRoutes: Routes = [
    { path: 'dashboard', component: DashboardComponent, canActivate: [AuthenticationGuard]}
];