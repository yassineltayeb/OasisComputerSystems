import { Component, OnInit } from '@angular/core';
import { AuthService } from '../../_services/auth.service';
import { AlertifyService } from '../../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  model: any = {};
  loading = false;

  constructor(public authService: AuthService, private alertify: AlertifyService, private router: Router) { }

  ngOnInit() {
  }

  login() {
    this.loadToggle();

    this.authService.login(this.model)
      .subscribe(next => {
        this.loadToggle();
        this.alertify.success('Logged in successfully');

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      }, () => {
        this.router.navigate(['/home']);

      });
  }

  loadToggle() {
    this.loading = !this.loading;
  }
}
