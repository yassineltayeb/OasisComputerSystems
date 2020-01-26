import { catchError } from 'rxjs/operators';
import { AlertifyService } from '../_services/alertify.service';
import { Injectable } from '@angular/core';
import { Resolve, ActivatedRouteSnapshot, Router } from '@angular/router';
import { Observable, of } from 'rxjs';
import { Ticket } from '../_models/ticket';
import { TicketService } from '../_services/ticket.service';

@Injectable()

export class TicketListResolver implements Resolve<Ticket[]> {

    ticketParams: any = {
        pageNumber: 1,
        pageSize: 10,
        itemsPerPage: 10
      };

    constructor(private ticketService: TicketService, private router: Router, private alertify: AlertifyService) {}

    resolve(route: ActivatedRouteSnapshot): Observable<Ticket[]> {
        // tslint:disable-next-line:no-string-literal
        return this.ticketService.getAllWithPagination(this.ticketParams).pipe(
            catchError(error => {
                this.alertify.error('Problem retrieving data');
                this.router.navigate(['/tickets']);
                return of(null);
            })
        );
    }

}
