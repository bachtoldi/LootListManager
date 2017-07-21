import { Component, OnInit } from '@angular/core';
import { NavigationComponent } from './navigation/navigation.component';
import { TranslateService, AuthenticationService } from './_services';

@Component({
  selector: 'll-app',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.scss']
})

export class AppComponent {

  constructor(private authService: AuthenticationService) { }

  hasToken() {
    return this.authService.isAuthenticated();
  }
}