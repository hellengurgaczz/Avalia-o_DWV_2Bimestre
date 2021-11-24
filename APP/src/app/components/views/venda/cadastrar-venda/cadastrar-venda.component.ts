import { FormasService } from './../../../../services/formas.service';
import { VendaService } from './../../../../services/venda.service';
import { FormasPag } from './../../../../models/formasPag';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { Venda } from 'src/app/models/venda';
import { ItemVenda } from './../../../../models/item-venda';



@Component({
  selector: 'app-cadastrar-venda',
  templateUrl: './cadastrar-venda.component.html',
  styleUrls: ['./cadastrar-venda.component.css']
})
export class CadastrarVendaComponent implements OnInit {

  nomeCliente!:string;
  formaPagamentoId!:number;
  formas!: FormasPag[];
  itemVendaId!: number;
  itens!: ItemVenda[];
  

  constructor(private router: Router, 
    private vendaService: VendaService, 
    private formaService: FormasService) { }

  ngOnInit(): void {
    this.formaService.list().subscribe((formas) => {
      this.formas = formas;
  });
  }

  cadastrar(): void{
    let venda : Venda = {
      cliente: this.nomeCliente,
      formaId: this.formaPagamentoId,
      itemVendaId: this.itemVendaId,
    };
    
    this.vendaService.create(venda).subscribe((venda) =>{
      this.router.navigate(["venda/listar"]);
    });
  }

}