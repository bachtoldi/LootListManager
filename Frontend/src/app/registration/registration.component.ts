import { Component } from '@angular/core';
import { TranslateService, UserService } from '../_services/index';
import { Router } from '@angular/router';

import { LoginUser } from '../_models/index';

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
    user: LoginUser = {
        username: '',
        password: ''
    };

    constructor(
        private translate: TranslateService,
        private userService: UserService,
        private router: Router) {
        this.username = this.translate.instant('username');
        this.password = this.translate.instant('password');
        this.passwordRepeat = this.translate.instant('passwordRepeat');
    }

    onSubmit() {
        if (this.user.password === this.passwordConfirmation) {
            this.userService.register(this.user.username, this.user.password)
                .subscribe(
                data => {
                    if (data == true) {
                        this.router.navigate(['/login']);
                    }
                },
                error => {
                    alert('error');
                });
        }
    }
}