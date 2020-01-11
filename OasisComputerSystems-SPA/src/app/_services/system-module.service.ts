import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { AbstractService } from './abstract.service';
import { KeyValuePairs } from '../_models/keyvaluepairs';

@Injectable({
  providedIn: 'root'
})
export class SystemModuleService extends AbstractService<KeyValuePairs>  {

  constructor(http: HttpClient) {
    super(http, environment.apiUrl + 'systemmodule');
  }

}
