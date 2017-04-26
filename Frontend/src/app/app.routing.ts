import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/index';
import { RegistrationComponent } from './registration/index';

const appRoutes: Routes = [
    { path: '', component: RegistrationComponent },
    { path: '**', redirectTo: '' },
    { path: 'login', component: LoginComponent },
    { path: 'registration', component: RegistrationComponent }
];

export const routing = RouterModule.forRoot(appRoutes);