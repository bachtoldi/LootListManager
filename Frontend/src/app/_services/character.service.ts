import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions, Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import { Character } from '../_models/index';

import * as globals from '../globals';

@Injectable()
export class CharacterService {

  constructor(private http: Http) { }

  getCharacter(): Observable<any> {
    const url = globals.backendUrl + '/Players/Characters';

    var token = JSON.parse(localStorage.getItem('currentUser')).token;

    var headers = new Headers();
    headers.append('Content-Type', 'application/json');
    headers.append('Accept', 'application/json');
    headers.append('Authorization', 'Bearer ' + token);

    var options = new RequestOptions({ headers: headers });

    let characters = this.http.get(url, options)
      .map(response => response.json().Items)
      .map(item => {
        return new Character(item.CharacterId, item.CharacterName, item.RaceFk, item.TalentFk);
      })
    // .map(
    // response => {
    //   return new Character(
    //     response.json().CharacterId,
    //     response.json().CharacterName,
    //     response.json().RaceFk,
    //     response.json().TalentFk);
    // });

    console.log(characters);

    return characters;
  }

  toCharacter(response: Response): Character {
    let characters: Character;

    console.log(response.json().Items);

    response.json().Items.foreach(item => {
      characters = <Character>{
        characterId: item.CharacterId,
        characterName: item.CharacterName,
        raceFk: item.RaceFk,
        talentFk: item.TalentFk
      };
    })

    console.log(characters);

    return characters;
  }

}
