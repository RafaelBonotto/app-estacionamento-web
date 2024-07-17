import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  constructor(private http: HttpClient) { }

  getPrecos(): Observable<any[]> {

    const url = 'https://localhost:44367/v1/valor';
    return this.http.get<any[]>(url);

  }
}