import { Component } from '@angular/core';
import { User } from '../login/login.component';
import { TranslateService } from '../_services/index';

@Component({
    moduleId: module.id,
    selector: 'registration',
    templateUrl: 'registration.component.html',
    styleUrls: ['registration.component.scss']
})

export class RegistrationComponent {
    public username: string;
    public password: string;
    public passwordRepeat: string;
    public passwordConfirmation: string;

    submitTitle = 'Registrieren';
    cancelTitle = 'Abbrechen';
    user: User = {
        username: '',
        password: ''
    };

    constructor(
        private _translate: TranslateService) {
        this.username = this._translate.instant('username');
        this.password = this._translate.instant('password');
        this.passwordRepeat = this._translate.instant('passwordRepeat');
    }

    onSubmit() {
        if(this.user.password === this.passwordConfirmation){

        }
    }
}