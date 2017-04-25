import { Component } from '@angular/core';
import { AuthenticationService } from './authentication.service';

export class User {
  username: string;
  password: string;
}

@Component({
  moduleId: module.id,
  selector: 'my-app',
  templateUrl: 'app.component.html'
})

export class AppComponent {
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
          alert('success');
        } else {
          alert('error');
        }
      });
  }
}
