import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormularioComponent } from "./formulario/formulario.component";
import { FormularioDetalheComponent } from "./formulario-detalhe/formulario-detalhe.component";

@Component({
  selector: 'MeuCrud-root',
  imports: [RouterOutlet, FormularioComponent, FormularioDetalheComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'MeuProjeto';
}
