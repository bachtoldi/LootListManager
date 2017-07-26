import { Component } from '@angular/core';
import { AuthenticationService, TranslateService } from '../_services';
import { Router } from '@angular/router';
import { LoginUser } from '../_models';

@Component({
  selector: 'll-login',
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.scss']
})

export class LoginComponent {
  user: LoginUser = new LoginUser();

  constructor(
    private authenticationSercie: AuthenticationService,
    private router: Router) { }

  onSubmit() {
    this.authenticationSercie.login(this.user.username, this.user.password)
      .subscribe(
      data => {
        if (data === true) {
          this.router.navigate(['/main/home']);
        }
      },
      error => {
        alert('login failed!');
      });
  }
}
