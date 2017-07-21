import { Component, OnInit } from '@angular/core';
import { UserService, TranslateService } from '../_services';
import { User } from '../_models';

@Component({
  selector: 'll-home',
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
    this.userService.getUser().subscribe(
      data => {
        this.user = data;
      }
    );
  }

}
