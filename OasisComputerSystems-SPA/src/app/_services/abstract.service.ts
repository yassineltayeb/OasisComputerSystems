import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { PaginatedResult } from '../_models/pagination';

@Injectable({
  providedIn: 'root'
})

export abstract class AbstractService<T> {

  constructor(protected http: HttpClient, protected Url: string) {}

  public add(item: T): Observable<T> {
    return this.http.post<T>(this.Url, item).pipe(map(res => res as T));
  }

  public addWithFormData(ticketFormData: FormData): Observable<T> {
    return this.http.post<T>(this.Url, ticketFormData).pipe(map(res => res as T));
  }

  public update(id: number, item: T): Observable<T> {
    return this.http.put<T>(this.Url + id, item).pipe(map(res => res as T));
  }

  public delete(id: number) {
    return this.http.delete(this.Url + id);
  }

  getAllWithPagination(modelParams?): Observable<PaginatedResult<T[]>>  {

    const paginatedResult: PaginatedResult<T[]> = new PaginatedResult<T[]>();

    return this.http.get<T[]>(this.Url + '?' + this.toQueryString(modelParams), { observe: 'response' })
    .pipe(
      map(response => {
        paginatedResult.result = response.body;

        if (response.headers.get('Pagination') != null) {
          paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }

        return paginatedResult;
      })
    );
  }

  getAll(): Observable<T[]>  {

    return this.http.get<T[]>(this.Url)
    .pipe(map(response => {
        return response;
      })
    );
  }

  private toQueryString(obj) {
    // tslint:disable-next-line:prefer-const
    let parts = [];

    // tslint:disable-next-line:forin
    for (const property in obj) {
      const value = obj[property];

      // tslint:disable-next-line:triple-equals
      if (value != null && value != undefined) {
        parts.push(encodeURIComponent(property) + '=' + encodeURIComponent(value));
      }
    }

    return parts.join('&');
  }

  get(id: number): Observable<T> {
    return this.http.get(`${this.Url}${id}`) as Observable<T>;
  }
}
