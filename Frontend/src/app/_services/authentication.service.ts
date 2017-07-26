import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map'
import * as globals from '../globals';

@Injectable()
export class AuthenticationService {

  constructor(private http: Http) { }

  login(username: string, password: string) {
    let header = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });

    const url = globals.backendUrl + '/auth/token';

    let body = 'grant_type=' + encodeURIComponent('password') +
      '&username=' + encodeURIComponent(username) +
      '&password=' + encodeURIComponent(password);

    let options = new RequestOptions({ headers: header });

    return this.http
      .post(url, body, options)
      .map((response: Response) => {
        let token = response.json() && response.json().access_token;
        if (token) {
          localStorage.setItem('currentUser', JSON.stringify({ username: username, token: token }));

          return true;
        } else {
          return false;
        }
      });
  }

  logout() {
    localStorage.removeItem('currentUser');
  }

  isAuthenticated() {
    return localStorage.getItem('currentUser');
  }

  getToken() {
    return JSON.parse(localStorage.getItem('currentUser')).token;
  }
}
