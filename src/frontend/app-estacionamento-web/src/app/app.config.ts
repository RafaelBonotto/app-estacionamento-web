import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { routes } from './app.routes';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { MenuComponent } from './menu/menu.component';
import { ErrorComponent } from './error/error.component';
import { ClienteComponent } from './cliente/cliente.component';
import { ClienteDetalhesComponent } from './cliente-detalhes/cliente-detalhes.component'; 
import { EntradaComponent } from './entrada/entrada.component'; 
import { SaidaComponent } from './saida/saida.component'; 

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    MenuComponent,
    ErrorComponent,
    ClienteComponent,
    ClienteDetalhesComponent,
    EntradaComponent,
    SaidaComponent
  ],
  imports: [
    FormsModule,
    HttpClientModule,
    BrowserModule,
    RouterModule.forRoot(routes),
       
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }