import { Component } from '@angular/core';
import { TranslateService, UserService } from '../_services';
import { Router } from '@angular/router';

import { LoginUser } from '../_models';

@Component({
    selector: 'll-registration',
    templateUrl: 'registration.component.html',
    styleUrls: ['registration.component.scss']
})

export class RegistrationComponent {
    passwordConfirmation: string;
    user: LoginUser = new LoginUser();

    constructor(
        private userService: UserService,
        private router: Router) { }

    onSubmit() {
        if (this.user.password === this.passwordConfirmation) {
            this.userService.register(this.user.username, this.user.password)
                .subscribe(
                data => {
                    if (data === true) {
                        this.router.navigate(['/login']);
                    }
                },
                error => {
                    alert('registration failed!');
                });
        }
    }
}