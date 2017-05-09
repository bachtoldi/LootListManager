import { Component } from '@angular/core';
import { AuthenticationService } from '../_services/index';
import { TranslateService } from '../translate/index';

export class User {
  username: string;
  password: string;
}

@Component({
  moduleId: module.id,
  selector: 'login',
  templateUrl: 'login.component.html',
  styleUrls: ['login.styles.css']
})

export class LoginComponent {
  public username: string;
  public password: string;

  user: User = {
    username: '',
    password: ''
  };

  constructor(
    private authenticationSercie: AuthenticationService,
    private _translate: TranslateService) {
    this.username = this._translate.instant('username');
    this.password = this._translate.instant('password');
  }

  onSubmit() {
    this.authenticationSercie.login(this.user.username, this.user.password)
      .subscribe(
      data => {
        if (data === true) {
          
        } else {
          alert("success");
        }
      });
  }
}