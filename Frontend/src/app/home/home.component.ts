import { Component, OnInit } from '@angular/core';
import { UserService } from '../_services/index';
import { User } from '../_models/index';

@Component({
  moduleId: module.id,
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent {

  user: User;

  constructor(private userService: UserService) { }

  getUser() {
    this.userService.getUser().subscribe(result => this.user = result);

    console.log(this.user);
  }

}
