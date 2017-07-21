import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { TranslateService } from '../_services/translate.service';

@Component({
  selector: 'll-languages',
  templateUrl: 'languages.component.html',
  styleUrls: ['languages.component.scss']
})

export class LanguagesComponent implements OnInit {
  constructor(private translate: TranslateService,
    private router: Router) { }

  ngOnInit() { }

  selectLanguage(lang: string) {
    this.translate.selectLanguage(lang);
  }
}