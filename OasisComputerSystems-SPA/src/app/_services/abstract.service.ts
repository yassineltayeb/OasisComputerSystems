import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export abstract class AbstractService<T> {

  constructor(protected http: HttpClient, protected Url: string) {}

  public add(item: T): Observable<T> {
    return this.http.post<T>(this.Url, item).pipe(map(res => res as T));
  }

  public update(id: number, item: T): Observable<T> {
    return this.http.put<T>(this.Url + id, item).pipe(map(res => res as T));
  }

  public delete(id: number) {
    return this.http.delete(this.Url + id).pipe(map(res => res));
  }

  getAll(): Observable<T[]> {
    return this.http.get(this.Url) as Observable<T[]>;
  }

  get(id: number): Observable<T> {
    return this.http.get(`${this.Url}${id}`) as Observable<T>;
  }
}
