import { Component, OnInit } from '@angular/core';
import { Character, Race, Class, Talent } from '../_models';
import { CharacterService, UserService } from '../_services';

@Component({
  selector: 'll-character',
  templateUrl: './character.component.html',
  styleUrls: ['./character.component.scss']
})
export class CharacterComponent implements OnInit {
  character: Character = new Character();
  races: Race[] = new Array<Race>();
  classes: Class[] = new Array<Class>();
  talents: Talent[] = new Array<Talent>();
  selectedClass: string;

  constructor(private characterService: CharacterService,
    private userService: UserService) { }

  ngOnInit() {
    this.userService.getUser().subscribe(
      data => {
        this.getCharacter(data.UserId);
      }
    );

    this.getRaces();
  }

  getCharacter(userId: number) {
    this.characterService.getCharacters(userId).subscribe(
      data => {
        if (data[0]) {
          this.character = data[0];
        } else {
          this.character = <Character>{
            CharacterId: 0,
            CharacterName: '',
            RaceFk: 0,
            TalentFk: 0,
            UserFk: userId
          };
        }
      }
    );
  }

  getRaces() {
    this.characterService.getRaces().subscribe(
      data => {
        this.races = data;
      }
    )
  }

  getClasses() {
    this.selectedClass = undefined;
    this.characterService.getClasses(this.character.RaceFk).subscribe(
      data => {
        this.classes = data;
      }
    )
  }

  getTalents() {
    this.character.TalentFk = 0;
    this.characterService.getTalents(this.selectedClass).subscribe(
      data => {
        this.talents = data;
      }
    )
  }

  cancel() {
    this.character.TalentFk = 0;
    this.selectedClass = undefined;
    this.character.RaceFk = 0;
  }

  save() {
    this.characterService.saveCharacter(this.character)
      .subscribe(
      data => {
        if (data === true) {
          window.location.reload();
        }
      },
      error => {
        alert('save failed');
      }
      );
  }
}
