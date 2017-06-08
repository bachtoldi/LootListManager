"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
var core_1 = require("@angular/core");
var router_1 = require("@angular/router");
var index_1 = require("../translate/index");
var LanguagesComponent = (function () {
    function LanguagesComponent(_translate, router) {
        this._translate = _translate;
        this.router = router;
    }
    LanguagesComponent.prototype.ngOnInit = function () {
        this._translate.supportedLanguages = [
            { display: 'English', value: 'en' },
            { display: 'Deutsch', value: 'de' }
        ];
        var currentLanguage = localStorage.getItem('currentLanguage');
        if (currentLanguage) {
            this.selectLanguage(currentLanguage);
        }
        else {
            this.selectLanguage('en');
        }
    };
    LanguagesComponent.prototype.isCurrentLanguage = function (lang) {
        return lang === this._translate.currentLanguage;
    };
    LanguagesComponent.prototype.selectLanguage = function (lang) {
        var containsLanguage = false;
        for (var i = 0; i < this._translate.supportedLanguages.length; i++) {
            if (this._translate.supportedLanguages[i].value == lang) {
                containsLanguage = true;
                break;
            }
        }
        if (containsLanguage) {
            this._translate.currentLanguage = lang;
        }
        else {
            this._translate.currentLanguage = 'en';
        }
    };
    LanguagesComponent.prototype.clickEnglish = function () {
        this.selectLanguage('en');
        localStorage.setItem('currentLanguage', 'en');
        window.location.reload();
    };
    LanguagesComponent.prototype.clickGerman = function () {
        this.selectLanguage('de');
        localStorage.setItem('currentLanguage', 'de');
        window.location.reload();
    };
    return LanguagesComponent;
}());
LanguagesComponent = __decorate([
    core_1.Component({
        moduleId: module.id,
        selector: 'languages',
        templateUrl: 'languages.component.html',
        styleUrls: ['languages.styles.css']
    }),
    __metadata("design:paramtypes", [index_1.TranslateService,
        router_1.Router])
], LanguagesComponent);
exports.LanguagesComponent = LanguagesComponent;
//# sourceMappingURL=languages.component.js.map