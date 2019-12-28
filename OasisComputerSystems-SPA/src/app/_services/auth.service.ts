import { environment } from './../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../_models/user';
import { AlertifyService } from './alertify.service';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  basUrl = environment.apiUrl +  'auth/';
  jwtHelper = new JwtHelperService();
  decodedToken: any;
  currentUser: User;

  constructor(private http: HttpClient, private router: Router, private alertify: AlertifyService) { }

  register(model: any) {
    return this.http.post(this.basUrl + 'register', model);
  }

  login(model: any) {

    console.log(model);

    return this.http.post(this.basUrl + 'login', model).pipe(map((response: any) => {
      console.log(response);
      if (response) {
        localStorage.setItem('token', response.token);
        localStorage.setItem('user', JSON.stringify(response.user));
        this.decodedToken = this.jwtHelper.decodeToken(response.token);
        this.currentUser = response.user;
      }
    }));
  }

  logout() {
    localStorage.removeItem('token');
    localStorage.removeItem('user');
    this.decodedToken = null;
    this.currentUser = null;
    this.alertify.message('Logged Out');
    this.router.navigate(['/login']);
  }

  loggedIn() {
    const token = localStorage.getItem('token');
    return !this.jwtHelper.isTokenExpired(token);
  }

}
