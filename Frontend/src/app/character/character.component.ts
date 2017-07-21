import { Component, OnInit } from '@angular/core';
import { Character } from '../_models';
import { CharacterService, UserService } from '../_services';

@Component({
  selector: 'app-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.scss']
})
export class CharacterComponent implements OnInit {

  character: Character = new Character();

  constructor(private characterService: CharacterService,
    private userService: UserService) { }

  ngOnInit() {
    this.userService.getUser().subscribe(
      data => {
        this.getCharacter(data.UserId);
      }
    );
  }

  getCharacter(userId: number) {
    this.characterService.getCharacters(userId).subscribe(
      data => {
        this.character = data[0];
      }
    );
  }

}
