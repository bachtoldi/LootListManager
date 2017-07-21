import { Injectable, Inject } from '@angular/core';
import { TRANSLATIONS } from '../translate/translations';

@Injectable()
export class TranslateService {
    public currentLanguage: string;
    public supportedLanguages: any[];

    constructor( @Inject(TRANSLATIONS) private translations: any) {
        this.supportedLanguages = [
            { display: 'English', value: 'en' },
            { display: 'Deutsch', value: 'de' }
        ];

        let currentLanguage = localStorage.getItem('currentLanguage');

        if (currentLanguage) {
            this.currentLanguage = currentLanguage;
        } else {
            this.currentLanguage = 'en';
        }
    }

    use(lang: string) {
        this.currentLanguage = lang;
    }

    selectLanguage(lang: string) {
        var selectedLanguage = this.supportedLanguages.find(x => x.value == lang).value;
        if (selectedLanguage && !this.isCurrentLanguage(lang)) {
            this.currentLanguage = selectedLanguage;

            localStorage.setItem('currentLanguage', lang);
            window.location.reload();
        }
    }

    isCurrentLanguage(lang: string) {
        return lang === this.currentLanguage;
    }

    private translate(key: string): string {
        let translation = key;

        if (this.translations[this.currentLanguage] && this.translations[this.currentLanguage][key]) {
            return this.translations[this.currentLanguage][key];
        }

        return translation;
    }

    instant(key: string) {
        return this.translate(key);
    }
}