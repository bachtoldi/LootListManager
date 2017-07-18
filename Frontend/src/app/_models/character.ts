import { Race, Talent } from './index';

export class Character {
    CharacterId: number;
    CharacterName: string;
    UserFk: number;
    RaceFk: number;
    TalentFk: number;
    constructor(id: number, name: string, user: number, race: number, talent: number){
        this.CharacterId = id;
        this.CharacterName = name;
        this.UserFk = user;
        this.RaceFk = race;
        this.TalentFk = talent;
    }
}