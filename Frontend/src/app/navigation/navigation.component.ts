import { Component } from '@angular/core';

@Component({
    moduleId: module.id,
    selector: 'navigation',
    templateUrl: 'navigation.component.html',
    styleUrls: ['navigation.component.scss']
})

export class NavigationComponent { 
    hasToken(){
        if (localStorage.getItem('currentUser')) {
            return true;
        }

        return false;
    }
}