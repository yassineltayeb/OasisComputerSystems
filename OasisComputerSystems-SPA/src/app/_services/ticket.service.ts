import { Injectable } from '@angular/core';
import { AbstractService } from './abstract.service';
import { Ticket } from '../_models/ticket';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable()

export class TicketService extends AbstractService<Ticket> {

  constructor(http: HttpClient) {
    super(http, environment.apiUrl + 'ticket/');
  }

}
