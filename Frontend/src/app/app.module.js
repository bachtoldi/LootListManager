"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var core_1 = require("@angular/core");
var platform_browser_1 = require("@angular/platform-browser");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/http");
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var index_1 = require("./login/index");
var index_2 = require("./registration/index");
var index_3 = require("./navigation/index");
var index_4 = require("./translate/index");
var index_5 = require("./languages/index");
var index_6 = require("./_guards/index");
var index_7 = require("./home/index");
var app_routing_module_1 = require("./app-routing.module");
var index_8 = require("./_services/index");
var AppModule = (function () {
    function AppModule() {
    }
    return AppModule;
}());
AppModule = __decorate([
    core_1.NgModule({
        imports: [
            platform_browser_1.BrowserModule,
            forms_1.FormsModule,
            http_1.HttpModule,
            router_1.RouterModule,
            app_routing_module_1.AppRoutingModule
        ],
        declarations: [
            app_component_1.AppComponent,
            index_1.LoginComponent,
            index_2.RegistrationComponent,
            index_3.NavigationComponent,
            index_4.TranslatePipe,
            index_7.HomeComponent,
            index_5.LanguagesComponent
        ],
        bootstrap: [
            app_component_1.AppComponent
        ],
        providers: [
            index_6.AuthGuard,
            index_8.AuthenticationService,
            index_4.TRANSLATION_PROVIDERS,
            index_4.TranslateService
        ]
    })
], AppModule);
exports.AppModule = AppModule;
//# sourceMappingURL=app.module.js.map