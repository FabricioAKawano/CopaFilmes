import { Component, OnInit } from '@angular/core';
import { HeaderService } from './header.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private headerService: HeaderService) { }
  
  ngOnInit(): void {
  }

  get titulo(): string{
    return this.headerService.headerData.titulo
  }

  get descricao(): string{
    return this.headerService.headerData.descricao
  }
}