import { Component } from '@angular/core';
import { AuthenticationService } from '../_services/index';

export class User {
  username: string;
  password: string;
}

@Component({
  moduleId: module.id,
  selector: 'login',
  templateUrl: 'login.component.html'
})

export class LoginComponent {
  title = 'Login';
  usernameTitle = "Username:";
  passwordTitle = "Password:";
  user: User = {
    username: '',
    password: ''
  };
  submitTitle = "Login";
  registerTitle = "Register";
  error = '';
  loading = false;

  constructor(
    private authenticationSercie: AuthenticationService
  ) { }

  onSubmit() {
    this.loading = true;
    this.authenticationSercie.login(this.user.username, this.user.password)
      .subscribe(
      data => {
        if (data === true) {

        } else {

        }
      });
  }
}