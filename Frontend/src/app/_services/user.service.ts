import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import 'rxjs/add/operator/map';

import * as globals from '../globals';

@Injectable()
export class UserService {

  constructor(private http: Http) { }

  getUser() {
    const url = globals.backendUrl + "/Auth/User/Current";

    var token = JSON.parse(localStorage.getItem('currentUser')).token;

    var headers = new Headers();
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    headers.append('Authorization', 'Bearer ' + token);

    // var headers = new Headers({ 'Authorization': 'Bearer ' + JSON.parse(token).token });
    var options = new RequestOptions({ headers: headers });

    return this.http.get(url, options)
      .map(response => console.log(response)).subscribe();
  }

}