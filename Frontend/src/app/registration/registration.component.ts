import { Component } from '@angular/core';
import { TranslateService, UserService } from '../_services';
import { Router } from '@angular/router';

import { LoginUser } from '../_models';

@Component({
    selector: 'registration',
    templateUrl: 'registration.component.html',
    styleUrls: ['registration.component.scss']
})

export class RegistrationComponent {
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
        private router: Router) { }

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