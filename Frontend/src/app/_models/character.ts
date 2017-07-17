import { Race, Talent } from './index';

export class Character {
    characterId: number;
    characterName: string;
    raceFk: number;
    talentFk: number;
    constructor(id: number, name: string, race: number, talent: number){
        this.characterId = id;
        this.characterName = name;
        this.raceFk = race;
        this.talentFk = talent;
    }
}