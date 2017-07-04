import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { User } from '../_models/index';

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

    let user = this.http.get(url, options)
      .map(this.toUser);

    return user;
  }

  toUser(response: Response): User {
    let user = <User>({
      userId: response.json().UserId,
      userName: response.json().UserName,
    });
    return user;
  }

}