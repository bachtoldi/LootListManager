import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/index';
import { RegistrationComponent } from './registration/index';
import { NavigationComponent } from './navigation/index';
import { TRANSLATION_PROVIDERS, TranslatePipe, TranslateService } from './translate/index';
import { LanguagesComponent } from './languages/index';
import { HomeComponent } from './home/index';

import { AppRoutingModule } from './app-routing.module';

import { AuthenticationService } from './_services/index';

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
    AuthenticationService,
    TRANSLATION_PROVIDERS,
    TranslateService
  ]
})

export class AppModule { }