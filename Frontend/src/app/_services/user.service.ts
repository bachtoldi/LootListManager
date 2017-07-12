import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { User } from '../_models/index';

import * as globals from '../globals';

@Injectable()
export class UserService {

  user: User;

  constructor(private http: Http) { }

  getUser(): User {
    const url = globals.backendUrl + "/Auth/User/Current";

    var token = JSON.parse(localStorage.getItem('currentUser')).token;

    var headers = new Headers();
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    headers.append('Authorization', 'Bearer ' + token);

    var options = new RequestOptions({ headers: headers });

    this.http.get(url, options)
      .map(this.toUser).subscribe(result => {
        this.user = result
      });

    return this.user;
  }

  toUser(response: Response): User {
    let user = <User>({
      userId: response.json().UserId,
      userName: response.json().UserName,
    });
    return user;
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