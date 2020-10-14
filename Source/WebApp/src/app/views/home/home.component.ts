import { FilmeService } from '../../components/filme/filme.service';
import { Filme } from './../../components/filme/filme.model';
import { Component, OnInit } from '@angular/core';
import { NavigationExtras, Router } from '@angular/router';
import { HeaderService } from 'src/app/components/template/header/header.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {  
  filmes: Filme[]
  countNumber: number[] = []
  qtdColunas: number = 4
  qtdSelecionados: number = 0
  qtdMaxSelecao: number = 8
  btnDisabled: boolean
  constructor(private filmeService: FilmeService, private router: Router, private headerService: HeaderService) { }

  ngOnInit(): void {
    this.headerService.headerData.titulo = "Fase de Seleção";
    this.headerService.headerData.descricao = "Selecione 8 filmes que você deseja que entrem na competição e depois pressione o botão Gerar Meu Campeonato para prosseguir.";
      this.btnDisabled = true;
      this.filmeService.obterFilmes().subscribe(filmes => {
          this.filmes = filmes.map(f => {
            f.selecionado = false
            f.disabled = false
            return f
          })          
          filmes.forEach((x, index) => {
            if(index == 0){
              this.countNumber.push(0)              
            }else if(index % this.qtdColunas == 0){
              this.countNumber.push(index)
            }
          })          
      });
  }

  validarSelecao(): void{
    this.qtdSelecionados = this.filmes.filter(f => f.selecionado).length
    let disabled: boolean = false;
    if(this.qtdSelecionados === this.qtdMaxSelecao){
      disabled = true
    }
    this.btnDisabled = !disabled
    this.filmes.filter(f => !f.selecionado).forEach(f => f.disabled = disabled)
  }

  gerarCampeonato():void{
    const queryParams: any = {}
    let filmesSelecionados = this.filmes.filter(f => f.selecionado)
    queryParams.selecionados = JSON.stringify( filmesSelecionados )
    const navigationExtras: NavigationExtras = {
      queryParams
    }
    this.router.navigate(['/resultado'], navigationExtras)
  }
}
