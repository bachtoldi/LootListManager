"use strict";
var router_1 = require("@angular/router");
var index_1 = require("./login/index");
var index_2 = require("./registration/index");
var appRoutes = [
    { path: 'login', component: index_1.LoginComponent },
    { path: 'registration', component: index_2.RegistrationComponent },
    { path: '', component: index_1.LoginComponent },
    { path: '**', redirectTo: '' }
];
exports.routing = router_1.RouterModule.forRoot(appRoutes);
//# sourceMappingURL=app.routing.js.map