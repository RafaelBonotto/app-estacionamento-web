import { Component } from '@angular/core';

@Component({
  selector: 'app-entrada',
  standalone: false,
  templateUrl: './entrada.component.html',
  styleUrl: './entrada.component.css'
})
export class EntradaComponent {
  entradaData = {
    data: '',
    placa: '',
    hrs: '',
    min: ''
  };

  onSubmit() {
    // Adicione aqui a lógica para enviar os dados para a API
    // Transformar os dados para maiúsculas antes de enviar
    this.entradaData.placa = this.entradaData.placa.toUpperCase();
    this.entradaData.hrs = this.entradaData.hrs.toString().toUpperCase();
    this.entradaData.min = this.entradaData.min.toString().toUpperCase();
    console.log(this.entradaData);
  }

  transformToUpper(event: Event) {
    const input = event.target as HTMLInputElement;
    input.value = input.value.toUpperCase();
  }
}

