import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { TranslateService } from '../translate/index';

@Component({
  moduleId: module.id,
  selector: 'languages',
  templateUrl: 'languages.component.html',
  styleUrls: ['languages.styles.css']
})

export class LanguagesComponent implements OnInit {
  constructor(private _translate: TranslateService,
    private router: Router) { }

  ngOnInit() {
    this._translate.supportedLanguages = [
      { display: 'English', value: 'en' },
      { display: 'Deutsch', value: 'de' }
    ];

    let currentLanguage = localStorage.getItem('currentLanguage');

    if (currentLanguage) {
      this.selectLanguage(currentLanguage);
    } else {
      this.selectLanguage('en');
    }
  }

  isCurrentLanguage(lang: string) {
    return lang === this._translate.currentLanguage;
  }

  selectLanguage(lang: string) {
    var containsLanguage = false;

    for (var i = 0; i < this._translate.supportedLanguages.length; i++) {
      if (this._translate.supportedLanguages[i].value == lang) {
        containsLanguage = true;
        break;
      }
    }

    if (containsLanguage) {
      this._translate.currentLanguage = lang;
    } else {
      this._translate.currentLanguage = 'en';
    }
  }

  clickEnglish() {
    this.selectLanguage('en');
    localStorage.setItem('currentLanguage', 'en');
    window.location.reload();
  }

  clickGerman() {
    this.selectLanguage('de');
    localStorage.setItem('currentLanguage', 'de');
    window.location.reload();
  }
}