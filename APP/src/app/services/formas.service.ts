import { FormasPag } from '../models/formasPag';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FormasService {

  private baseUrl = "http://localhost:5000/api/pagamento";

  constructor(private http: HttpClient) {}

  list(): Observable<FormasPag[]> {
      return this.http.get<FormasPag[]>(`${this.baseUrl}/list`);
  }
}