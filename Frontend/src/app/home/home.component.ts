import { Component, OnInit } from '@angular/core';
import { UserService, TranslateService } from '../_services/index';
import { User } from '../_models/index';

@Component({
  moduleId: module.id,
  selector: 'home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})

export class HomeComponent implements OnInit {

  user: User = new User();

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.getUser();
  }

  getUser() {
    this.userService.getUser().subscribe(result => {
      this.user = result;
    });
  }

}
