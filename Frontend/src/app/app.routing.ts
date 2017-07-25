import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './_guards';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { RegistrationComponent } from './registration/registration.component';
import { HomeComponent } from './home/home.component';
import { CharacterComponent } from './character/character.component';
import { MainComponent } from './main/main.component';

const appRoutes: Routes = [
    { path: 'login', component: LoginComponent },
    { path: 'registration', component: RegistrationComponent },
    {
        path: 'main', component: MainComponent, canActivate: [AuthGuard],
        children: [
            { path: 'character', component: CharacterComponent },
            { path: 'home', component: HomeComponent },
            { path: '', component: HomeComponent },
            { path: '**', redirectTo: '' }
        ]
    },
    { path: '', component: MainComponent, canActivate: [AuthGuard] },
    { path: '**', redirectTo: '' }
];

@NgModule({
    imports: [
        RouterModule.forRoot(appRoutes)
    ],
    exports: [
        RouterModule
    ]
})

export class AppRoutingModule { }