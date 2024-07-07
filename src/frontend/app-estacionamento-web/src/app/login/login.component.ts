import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../login.service';
import { take } from 'rxjs/operators'; // Importe o operador take

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
  standalone: false
})
export class LoginComponent {
  email = '';
  password = '';

  constructor(private router: Router, private loginService: LoginService) {}

  async onSubmit() {
    try {
      // Chamada assíncrona ao serviço usando await com take(1)
      await this.loginService.validateUser(this.email, this.password).pipe(take(1)).toPromise();

      // Usuário autenticado, navegue para a tela de menu
      this.router.navigate(['/menu']);
    } catch (error) {
      // Erro na validação, navegue para a tela de erro
      this.router.navigate(['/error']);
    }
  }
}