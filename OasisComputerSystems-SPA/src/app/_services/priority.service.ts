import { Injectable } from '@angular/core';
import { AbstractService } from './abstract.service';
import { KeyValuePairs } from '../_models/keyvaluepairs';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PriorityService extends AbstractService<KeyValuePairs> {

  constructor(http: HttpClient) {
    super(http, environment.apiUrl + 'priority');
  }

}
