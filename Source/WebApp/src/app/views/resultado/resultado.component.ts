import { Resultado } from './../../components/filme/resultado.model';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Filme } from 'src/app/components/filme/filme.model';
import { FilmeService } from 'src/app/components/filme/filme.service';
import { HeaderService } from 'src/app/components/template/header/header.service';

@Component({
  selector: 'app-resultado',
  templateUrl: './resultado.component.html',
  styleUrls: ['./resultado.component.css']
})
export class ResultadoComponent implements OnInit {

  resultado: Resultado
  selecionados: Filme[]

  constructor(private route: ActivatedRoute, private filmeService: FilmeService, private headerService: HeaderService) { }

  ngOnInit(): void {
    this.headerService.headerData.titulo = "Resultado Final";
    this.headerService.headerData.descricao = "Veja o resultado final do Campeonato de Filmes de forma simples e rápida";

    const selecionados = this.route.snapshot.queryParamMap.get('selecionados')    
    this.filmeService.obterResultado(selecionados).subscribe(res => {
      this.resultado = res
    })
  }
}
