import { Component, OnInit } from '@angular/core';
import { NavigationComponent } from './navigation/navigation.component';
import { TranslateService } from './_services/index';

@Component({
  moduleId: module.id,
  selector: 'my-app',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})

export class AppComponent {
  hasToken() {
    if (localStorage.getItem('currentUser')) {
      return true;
    }

    return false;
  }
}