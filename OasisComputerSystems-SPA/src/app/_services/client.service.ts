import { Injectable } from '@angular/core';
import { AbstractService } from './abstract.service';
import { Client } from '../_models/client';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KeyValuePairs } from '../_models/keyvaluepairs';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable()

export class ClientService extends AbstractService<Client> {

  constructor(http: HttpClient) {
    super(http, environment.apiUrl + 'client/');
  }

  getAllClients(): Observable<KeyValuePairs[]> {

    return this.http.get<KeyValuePairs[]>(environment.apiUrl + 'client/getAllClients')
      .pipe(map(response => {
        return response;
      })
      );
  }
}
