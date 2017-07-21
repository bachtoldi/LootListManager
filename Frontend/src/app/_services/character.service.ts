import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Character } from '../_models';
import { UserService } from '.';

import * as globals from '../globals';

@Injectable()
export class CharacterService {

  constructor(private http: Http,
    private userService: UserService) { }

  getCharacters(userId = -1): Observable<Character[]> {
    if (userId === -1) {
      var url = globals.backendUrl + '/Players/Characters';
    } else {
      var url = globals.backendUrl + '/Players/Characters?userId=' + userId;
    }

    var token = JSON.parse(localStorage.getItem('currentUser')).token;

    var headers = new Headers();
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    headers.append('Authorization', 'Bearer ' + token);

    var options = new RequestOptions({ headers: headers });

    return this.http.get(url, options)
      .map(response => response.json().Items as Character[]);
  }

}
