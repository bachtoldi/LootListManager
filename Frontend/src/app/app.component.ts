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

  constructor(
    private authenticationSercie: AuthenticationService
  ) { }

  onSubmit() {
    this.authenticationSercie.login(this.user.username, this.user.password)
    .subscribe(
      data => {
        alert("success");
      },
      error =>{
        alert("error");
      }
    );
  }
}
