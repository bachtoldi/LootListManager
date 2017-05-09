import { Component } from '@angular/core';
import { User } from '../login/index';
import { TranslateService } from '../translate/index';

@Component({
    moduleId: module.id,
    selector: 'registration',
    templateUrl: 'registration.component.html',
    styleUrls: ['registration.styles.css']
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