import { Component } from '@angular/core';
import { User } from './app.component';

@Component({
    moduleId: module.id,
    selector: 'registration',
    templateUrl: 'registration.component.html'
})

export class RegistrationComponent {
    title: 'Registrierung';
    usernameTitle: 'Benutzername';
    passwordTitle: 'Passwort';
    passwordConfirmationTitle: 'Passwort wiederholen';
    submitTitle: 'Registrieren';
    cancelTitle: 'Abbrechen';
    user: User = {
        username: '',
        password: ''
    };
    passwordConfirmation: string;
}