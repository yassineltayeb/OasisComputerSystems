import { Injectable } from '@angular/core';
import { AbstractService } from './abstract.service';
import { Client } from '../_models/client';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable()

export class ClientService extends AbstractService<Client> {

  private readonly baseUrl = environment.apiUrl + 'client/';

constructor(http: HttpClient) {
  super(http, environment.apiUrl + 'client/');
 }
}
