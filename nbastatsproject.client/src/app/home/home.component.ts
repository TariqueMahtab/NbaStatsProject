import { Component, OnInit } from '@angular/core';
import { PlayerService, Player } from '../player.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html'
})
export class HomeComponent implements OnInit {
  players: Player[] = [];

  constructor(private svc: PlayerService) { }

  ngOnInit() {
    this.svc.getPlayers().subscribe(data => this.players = data);
  }
}
