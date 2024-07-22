import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MenuComponent } from './menu/menu.component';
import { ErrorComponent } from './error/error.component';
import { ClienteComponent } from './cliente/cliente.component';
import { ClienteDetalhesComponent } from './cliente-detalhes/cliente-detalhes.component';
import { EntradaComponent } from './entrada/entrada.component'; 
import { SaidaComponent } from './saida/saida.component'; 

export const routes: Routes = [
  // Redireciona para a tela de login por padrão
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'menu', component: MenuComponent },
  { path: 'error', component: ErrorComponent },
  { path: 'cliente', component: ClienteComponent },
  { path: 'entrada', component: EntradaComponent },
  { path: 'saida', component: SaidaComponent },
  { path: 'cliente-detalhes/:id', component: ClienteDetalhesComponent },
  { path: '', redirectTo: '/cliente', pathMatch: 'full' }
];