import { Component, OnInit } from '@angular/core';
import { Character } from '../_models/index';
import { CharacterService, UserService } from '../_services/index';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.scss']
})
export class CharacterComponent implements OnInit {

  characters: Character[];
  userId: number;

  constructor(private characterService: CharacterService,
    private userService: UserService) { }

  ngOnInit() {
    this.userService.getUser().subscribe(data => this.userId = data.UserId);
    this.getCharacter();
  }

  getCharacter() {
    this.characterService.getCharacter(this.userId).subscribe();
  }

}
