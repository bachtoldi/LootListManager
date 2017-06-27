import { Component } from '@angular/core';
import { AuthenticationService, TranslateService } from '../_services/index';
import { Router } from '@angular/router';

export class User {
  username: string;
  password: string;
}

@Component({
  moduleId: module.id,
  selector: 'login',
  templateUrl: 'login.component.html',
  styleUrls: ['login.component.scss']
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
    private _translate: TranslateService,
    private router: Router) {
    this.username = this._translate.instant('username');
    this.password = this._translate.instant('password');
  }

  onSubmit() {
    this.authenticationSercie.login(this.user.username, this.user.password)
      .subscribe(
      data => {
        if (data === true) {
          let string = localStorage.getItem('currentUser');
          this.router.navigate(['/home']);
        }
      },
      error => {
        alert("error");
      });
  }
}