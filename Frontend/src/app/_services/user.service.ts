import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { User } from '../_models';

import * as globals from '../globals';

@Injectable()
export class UserService {

  constructor(private http: Http) { }

  getUser(): Observable<User> {
    const url = globals.backendUrl + "/Auth/User/Current";

    var token = JSON.parse(localStorage.getItem('currentUser')).token;

    var headers = new Headers();
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    headers.append('Authorization', 'Bearer ' + token);

    var options = new RequestOptions({ headers: headers });

    return this.http.get(url, options)
      .map(response => response.json() as User);
  }

  register(username: string, password: string) {
    const url = globals.backendUrl + "/Auth/Register";

    var headers = new Headers();
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');

    var options = new RequestOptions({ headers: headers });

    var body = {
      UserName: username,
      UserPassword: password
    };

    return this.http
      .post(url, body, options)
      .map((response: Response) => {
        if (response.status == 200) {
          return true;
        } else {
          return false;
        }
      })
  }
}