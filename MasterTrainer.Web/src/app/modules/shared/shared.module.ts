import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from '@angular/common/http';

// Components
import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';

// Services
import { AuthenticationApiService } from './services/authentication-api.service';

// Guards
import { AuthenticationGuard } from '../shared/guards/authentication.guard';

@NgModule({
    declarations: [
        HeaderComponent,
        FooterComponent
    ],
    imports: [
        CommonModule,
        FormsModule,
        RouterModule,
        HttpClientModule
    ],
    exports: [
        HeaderComponent,
        FooterComponent
    ],
    providers: [
        AuthenticationApiService,
        AuthenticationGuard
    ]
})

export class SharedModule { }