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
    let token = localStorage.getItem('currentUser');
    
    if (token != null) {
      return true;
    }

    return false;
  }
}