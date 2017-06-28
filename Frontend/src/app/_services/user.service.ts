import { Injectable } from '@angular/core';
import * as globals from '../globals';

@Injectable()
export class UserService {

  constructor() { }

  getUser() {
    let token = localStorage.getItem('currentUser');
    const url = globals.backendUrl + "/User/Current";
  }

}
