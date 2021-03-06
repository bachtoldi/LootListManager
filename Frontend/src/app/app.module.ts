import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { NavigationComponent } from './navigation/navigation.component';
import { LanguagesComponent } from './languages/languages.component';
import { HomeComponent } from './home/home.component';

import { AppRoutingModule } from './app.routing';
import { AuthGuard } from './_guards/index';
import { TRANSLATION_PROVIDERS, TranslatePipe } from './translate/index';
import { AuthenticationService, TranslateService, UserService } from './_services/index';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    RouterModule,
    AppRoutingModule
  ],
  declarations: [
    AppComponent,
    LoginComponent,
    RegistrationComponent,
    NavigationComponent,
    TranslatePipe,
    HomeComponent,
    LanguagesComponent
  ],
  bootstrap: [
    AppComponent
  ],
  providers: [
    AuthGuard,
    AuthenticationService,
    TRANSLATION_PROVIDERS,
    TranslateService,
    UserService,
  ]
})

export class AppModule { }