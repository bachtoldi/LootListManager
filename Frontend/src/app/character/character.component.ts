import { Component, OnInit } from '@angular/core';
import { Character } from '../_models/index';
import { CharacterService } from '../_services/index';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.scss']
})
export class CharacterComponent implements OnInit {

  characters: Character[];

  constructor(private characterService: CharacterService) { }

  ngOnInit() {
    this.getCharacter();
  }

  getCharacter() {
    this.characterService.getCharacter().subscribe();
  }

}
