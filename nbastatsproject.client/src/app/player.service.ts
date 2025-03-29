import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Player {
  id: number;
  fullName: string;
  position: string;
  pointsPerGame: number;
  reboundsPerGame: number;
  assistsPerGame: number;
  team: {
    name: string;
  };
}

@Injectable({
  providedIn: 'root'
})
export class PlayerService {
  private apiUrl = 'http://localhost:5140/api/Players'; // match your Swagger port

  constructor(private http: HttpClient) { }

  getPlayers(): Observable<Player[]> {
    return this.http.get<Player[]>(this.apiUrl);
  }
}
