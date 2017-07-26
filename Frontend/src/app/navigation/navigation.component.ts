import { Component } from '@angular/core';

import { AuthenticationService } from '../_services';

@Component({
    selector: 'll-navigation',
    templateUrl: 'navigation.component.html',
    styleUrls: ['navigation.component.scss']
})

export class NavigationComponent {

    constructor(private authService: AuthenticationService) { }

    logout() {
        localStorage.removeItem('currentUser');
    }
}
