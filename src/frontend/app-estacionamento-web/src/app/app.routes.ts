import { Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { MenuComponent } from './menu/menu.component';
import { ErrorComponent } from './error/error.component';

export const routes: Routes = [
  // Redireciona para a tela de login por padrão
  { path: '', redirectTo: 'login', pathMatch: 'full' },
  { path: 'login', component: LoginComponent },
  { path: 'menu', component: MenuComponent },
  { path: 'error', component: ErrorComponent },
  { path: 'option1', component: LoginComponent }, 
  { path: 'option2', component: LoginComponent }, 
  { path: 'option3', component: LoginComponent }, // Substitr pelo component da opção do menu
];