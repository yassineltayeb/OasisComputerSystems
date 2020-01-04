import { Injectable } from '@angular/core';
import { KeyValuePairs } from '../_models/keyvaluepairs';
import { AbstractService } from './abstract.service';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CountryService extends AbstractService<KeyValuePairs> {

  constructor(http: HttpClient) {
    super(http, environment.apiUrl + 'country');
  }

}
