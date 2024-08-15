import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { MenuService } from '../services/menu.service';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css',
  standalone: false
})
export class MenuComponent implements OnInit {

  precos: any[] = [];

  constructor(private router: Router, private menuService: MenuService) {}

  ngOnInit(): void {
    this.menuService.getPrecos().subscribe(
      (response: any[]) => {
        this.precos = response;
      },
      (error: any) => {
        console.error('Erro ao buscar dados:', error);
        this.router.navigate(['/error']);
      }
    );
  }  
}

