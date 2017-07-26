import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Character, Race, Class, Talent } from '../_models';
import { UserService, AuthenticationService } from '.';

import * as globals from '../globals';

@Injectable()
export class CharacterService {

  constructor(private http: Http,
    private userService: UserService,
    private authService: AuthenticationService) { }

  getCharacters(userId = -1): Observable<Character[]> {
    let url: string;
    let options = this.getOptions();

    if (userId === -1) {
      url = globals.backendUrl + '/Players/Characters';
    } else {
      url = globals.backendUrl + '/Players/Characters?userId=' + userId;
    }

    return this.http.get(url, options)
      .map(response => response.json().Items as Character[]);
  }

  saveCharacter(character: Character) {
    let url = globals.backendUrl + '/Players/Characters';
    let options = this.getOptions();

    return this.http
      .post(url, character, options)
      .map((response: Response) => {
        if (response.status === 200) {
          return true;
        } else {
          return false;
        }
      })
  }

  getRaces(): Observable<Race[]> {
    let url = globals.backendUrl + '/Players/Races?factionLogicalId=' + globals.faction;
    let options = this.getOptions();

    return this.http.get(url, options)
      .map(response => response.json().Items as Race[]);
  }

  getClasses(raceId: number): Observable<Class[]> {
    let url = globals.backendUrl + '/Players/Classes?raceId=' + raceId;
    let options = this.getOptions();

    return this.http.get(url, options)
      .map(response => response.json().Items as Class[]);
  }

  getTalents(classLogicalId: string): Observable<Talent[]> {
    let url = globals.backendUrl + '/Players/Talents?classLogicalId=' + classLogicalId;
    let options = this.getOptions();

    return this.http.get(url, options)
      .map(response => response.json().Items as Talent[]);
  }

  private getOptions(): RequestOptions {
    var headers = new Headers();

    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    headers.append('Authorization', 'Bearer ' + this.authService.getToken());

    return new RequestOptions({ headers: headers });
  }

}
