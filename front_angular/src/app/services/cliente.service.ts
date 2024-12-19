import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CommonModule } from '@angular/common';

@Injectable({
  providedIn: 'root',
})
export class ClienteService {
  private baseUrl = 'https://localhost:7129/api/Cliente/linq';
  httpHeaders = new HttpHeaders({'Content-Type': 'application/json'});

  constructor(private http: HttpClient) { }

  getClientes(page: number, pageSize: number): Observable<any[]> {
    const apiUrl = `${this.baseUrl}?page=${page}&pageSize=${pageSize}`;
    console.log(apiUrl);
    return this.http.get<any[]>('https://localhost:7129/api/Cliente/linq?page=1&pageSize=10',
      {headers: this.httpHeaders}
    );
  }
}
