import { Injectable, Inject } from '@angular/core';
import { TRANSLATIONS } from '../translate/translations';

@Injectable()
export class TranslateService {
    public currentLanguage: string;
    public supportedLanguages: any[];

    constructor( @Inject(TRANSLATIONS) private _translations: any) { }

    public use(lang: string): void {
        this.currentLanguage = lang;
    }

    private translate(key: string): string {
        let translation = key;

        if (this._translations[this.currentLanguage] && this._translations[this.currentLanguage][key]) {
            return this._translations[this.currentLanguage][key];
        }

        return translation;
    }

    public instant(key: string) {
        return this.translate(key);
    }
}