import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { mainRoutes } from './modules/main/main.routes';
import { authenticationRoutes } from './modules/authentication/authentication.routes';
import { gameRoutes } from './modules/game/game.routes';
import { registrationRoutes } from './modules/registration/registration.routes';

const routes: Routes = [
    { path: '', redirectTo: 'home', pathMatch: 'full' },
    ...mainRoutes,
    ...authenticationRoutes,
    ...gameRoutes,
    ...registrationRoutes
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
