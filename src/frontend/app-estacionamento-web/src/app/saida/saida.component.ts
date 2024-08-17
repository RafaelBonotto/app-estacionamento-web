import { Component, OnInit  } from '@angular/core';

@Component({
  selector: 'app-saida',
  standalone: false,
  templateUrl: './saida.component.html',
  styleUrl: './saida.component.css'
})
export class SaidaComponent {
  currentDate: string = "";

  saidaData = {
    data: '',
    placa: '',
    hrs: '',
    min: ''
  };

  
  ngOnInit(): void {
    this.updateCurrentDate();
  }

  onSubmit() {
    // Adicione aqui a lógica para enviar os dados para a API
    // Transformar os dados para maiúsculas antes de enviar
    this.saidaData.placa = this.saidaData.placa.toUpperCase();
    this.saidaData.hrs = this.saidaData.hrs.toString().toUpperCase();
    this.saidaData.min = this.saidaData.min.toString().toUpperCase();
    console.log(this.saidaData);
  }

  updateCurrentDate(): void {
    const now = new Date();
    this.currentDate = now.toLocaleDateString('pt-BR', {
      day: '2-digit',
      month: '2-digit',
      year: 'numeric'
    });
  }

  transformToUpper(event: Event) {
    const input = event.target as HTMLInputElement;
    input.value = input.value.toUpperCase();
  }
}
