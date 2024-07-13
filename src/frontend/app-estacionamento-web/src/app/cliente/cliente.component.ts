import { Component } from '@angular/core';
import { ClienteService } from '../services/cliente.service'; 
import { Router } from '@angular/router';
// import * as bootstrap from 'bootstrap'; 

@Component({
  selector: 'app-cliente',
  standalone: false,
  templateUrl: './cliente.component.html',
  styleUrl: './cliente.component.css'
})
export class ClienteComponent {

  showForm = false;
  cliente = {
    nome: '',
    cpf: '',
    email: '',
    telefone: '',
    logradouro: '',
    numero: '',
    complemento: '',
    bairro: '',
    cidade: '',
    estado: '',
    cep: ''
  };

  constructor(private clienteService: ClienteService, private router: Router) {}

  onSubmit() {
    this.clienteService.cadastrarCliente(this.cliente).subscribe(response => {
      console.log('Cliente cadastrado:', response);
      
      // // Fechar o modal usando Bootstrap
      // const modalElement = document.getElementById('cadastroModal');
      // const modal = bootstrap.Modal.getInstance(modalElement); // Recuperar a instância do modal
      // if (modal) {
      //   modal.hide();
      // }

      // Redirecionar para a tela de detalhes do cliente
      this.router.navigate(['/cliente-detalhes', response.id]);
    });
  }

}
