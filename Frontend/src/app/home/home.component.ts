import { Component, OnInit } from '@angular/core';
import { UserService } from '../_services/index';

@Component({
  moduleId: module.id,
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  constructor(private userService: UserService) { }

  user() {
    this.userService.getUser();
  }

}
