import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/index';
import { RegistrationComponent } from './registration/index';
import { NavigationComponent } from './navigation/index';

import { routing } from './app.routing';

import { AuthenticationService } from './_services/index';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule,
    routing
  ],
  declarations: [
    AppComponent,
    LoginComponent,
    RegistrationComponent,
    NavigationComponent
  ],
  bootstrap: [
    AppComponent
  ],
  providers: [
    AuthenticationService
  ]
})

export class AppModule { }
