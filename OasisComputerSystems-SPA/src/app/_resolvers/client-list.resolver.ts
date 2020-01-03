import { catchError } from 'rxjs/operators';
import { AlertifyService } from '../_services/alertify.service';
import { Injectable } from '@angular/core';
import { User } from '../_models/user';
import { Resolve, ActivatedRouteSnapshot, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { Client } from '../_models/client';
import { ClientService } from '../_services/client.service';

@Injectable()

export class ClientListResolver implements Resolve<Client[]> {

    clientParams: any = {
        pageNumber: 1,
        pageSize: 10,
        itemsPerPage: 10
      };

    constructor(private userService: ClientService, private router: Router, private alertify: AlertifyService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<Client[]> {
        // tslint:disable-next-line:no-string-literal
        return this.userService.getAll(this.clientParams).pipe(
            catchError(error => {
                this.alertify.error('Problem retrieving data');
                this.router.navigate(['/clients']);
                return of(null);
            })
        );
    }

}
