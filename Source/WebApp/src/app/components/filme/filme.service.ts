import { Resultado } from './resultado.model';
import { Filme } from './filme.model';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FilmeService {
  baseUrl: string
  constructor(private http: HttpClient) {
    this.baseUrl = "http://localhost:5000/api/v1/copa"
   }

  obterFilmes(): Observable<Filme[]>{
    return this.http.get<Filme[]>(this.baseUrl)
  }

  obterResultado(selecionados: string): Observable<Resultado>{
    const headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
    return this.http.post<Resultado>(this.baseUrl, selecionados, {headers: headers})
  }
}
