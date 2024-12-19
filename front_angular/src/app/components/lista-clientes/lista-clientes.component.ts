import { Component, inject, OnInit } from '@angular/core';
import { ClienteService } from '../../services/cliente.service';
import { Observable, of } from 'rxjs';
import { FormatoTelefonoPipe } from "../../pipes/formato-telefono.pipe";
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-lista-clientes',
  standalone: true,
  imports: [FormatoTelefonoPipe, CommonModule, HttpClientModule],
  templateUrl: './lista-clientes.component.html',
  styleUrl: './lista-clientes.component.css'
})
export class ListaClientesComponent implements OnInit {
  clientes$: any;

  private clienteService = inject(ClienteService);

  constructor() {}

  ngOnInit(): void {
    const pagina = 1;
    const tamanoPagina = 10;

    this.clientes$ = this.clienteService.getClientes(pagina, tamanoPagina);
  }
}
