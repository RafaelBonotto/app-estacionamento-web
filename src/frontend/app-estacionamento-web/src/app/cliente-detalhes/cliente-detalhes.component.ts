import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { ClienteService } from '../services/cliente.service'; 

@Component({
  selector: 'app-cliente-detalhes',
  standalone: false,
  templateUrl: './cliente-detalhes.component.html',
  styleUrl: './cliente-detalhes.component.css'
})

export class ClienteDetalhesComponent implements OnInit {
  cliente: any;

  constructor(private route: ActivatedRoute, private clienteService: ClienteService) { }

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    this.clienteService.getClienteById(id).subscribe(cliente => {
      this.cliente = cliente;
    });
  }
}
