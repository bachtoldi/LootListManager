import { Race, Talent } from './index';

export class Character {
    CharacterId: number;
    CharacterName: string;
    UserFk: number;
    RaceFk: number;
    TalentFk: number;
}