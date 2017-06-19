import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map'

@Injectable()
export class AuthenticationService {
  public token: string;

  constructor(private http: Http) {
    var currentUser = JSON.parse(localStorage.getItem('currentUser'));
    this.token = currentUser && currentUser.token;
  }

  login(username: string, password: string) {
    let header = new Headers({ 'Content-Type': 'application/x-www-form-urlencoded' });

    const url = 'http://localhost:11970/auth/token';

    let body = 'grant_type=' + encodeURIComponent('password') +
      '&username=' + encodeURIComponent(username) +
      '&password=' + encodeURIComponent(password);

    let options = new RequestOptions({ headers: header });

    return this.http
      .post(url, body, header)
      .map((response: Response) => {
        // login successful if there's a jwt token in the response
        let token = response.json() && response.json().access_token;
        if (token) {
          this.token = token;
          localStorage.setItem('currentUser', JSON.stringify({ username: username, token: token }));

          return true;
        } else {
          return false;
        }
      });
  }

  logout() {
    // remove user from local storage to log user out
    localStorage.removeItem('currentUser');
  }
}
