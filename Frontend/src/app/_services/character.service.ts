import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Character } from '../_models/index';
import { UserService } from './index';

import * as globals from '../globals';

@Injectable()
export class CharacterService {

  constructor(private http: Http,
    private userService: UserService) { }

  getCharacter(userId: number): Observable<Character> {

    var url = globals.backendUrl + '/Players/Characters?userId=' + userId;


    console.log(url);

    return null;
  }

  getCharacters(): Observable<Character[]> {
    const url = globals.backendUrl + '/Players/Characters';

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
