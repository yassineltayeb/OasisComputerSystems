import { Injectable } from '@angular/core';
import { AbstractService } from './abstract.service';
import { Ticket } from '../_models/ticket';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { ClientsActiveTickets } from '../_models/clientsactivetickets';
import { map } from 'rxjs/operators';

@Injectable()

export class TicketService extends AbstractService<Ticket> {

  constructor(http: HttpClient) {
    super(http, environment.apiUrl + 'ticket/');
  }

  getClientsActiveTickets(): Observable<ClientsActiveTickets[]> {

    return this.http.get<ClientsActiveTickets[]>(environment.apiUrl + 'ticket/getClientsActiveTickets')
      .pipe(map(response => {
        return response;
      })
      );
  }

}
