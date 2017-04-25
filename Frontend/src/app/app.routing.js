"use strict";
var router_1 = require("@angular/router");
var app_component_1 = require("./app.component");
var login_component_1 = require("./login.component");
var registration_component_1 = require("./registration.component");
var appRoutes = [
    { path: '', component: app_component_1.AppComponent },
    { path: '**', redirectTo: '' },
    { path: 'login', component: login_component_1.LoginComponent },
    { path: 'register', component: registration_component_1.RegistrationComponent }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map