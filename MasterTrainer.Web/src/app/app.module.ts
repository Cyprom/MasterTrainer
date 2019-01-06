import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

// Modules
import { AppRoutingModule } from './app-routing.module';
import { MainModule } from './modules/main/main.module';
import { SharedModule } from './modules/shared/shared.module';
import { AuthenticationModule } from './modules/authentication/authentication.module';
import { GameModule } from './modules/game/game.module';
import { NavigationModule } from './modules/navigation/navigation.module';
import { RegistrationModule } from './modules/registration/registration.module';

// Components
import { AppComponent } from './app.component';

@NgModule({
    declarations: [
        AppComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        MainModule,
        SharedModule,
        AuthenticationModule,
        GameModule,
        NavigationModule,
        RegistrationModule
    ],
    providers: [],
    bootstrap: [AppComponent]
})

export class AppModule { }
