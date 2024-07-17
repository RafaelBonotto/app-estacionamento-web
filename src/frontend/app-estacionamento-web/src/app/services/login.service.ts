import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class LoginService {

  constructor(private http: HttpClient) { }

  validateUser(email: string, password: string): Observable<any> {
    // Substitua pela URL real da sua API
    const url = 'https://localhost:44367/v1/Usuario/login';
    return this.http.post(url, { email, password });
  }
}