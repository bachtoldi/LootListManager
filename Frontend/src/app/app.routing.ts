import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginComponent } from './login.component';
import { RegistrationComponent } from './registration.component';

const appRoutes: Routes = [
    { path: '', component: AppComponent },
    { path: '**', redirectTo: '' },
    { path: 'login', component: LoginComponent },
    { path: 'register', component: RegistrationComponent }
];

export const routing = RouterModule.forRoot(appRoutes);