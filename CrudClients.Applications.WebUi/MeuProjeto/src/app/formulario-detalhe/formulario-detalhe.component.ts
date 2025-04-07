import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { BackendService } from '../backend.service';

@Component({
    selector: 'MeuCrud-formulario-detalhe',
    imports: [],
    templateUrl: './formulario-detalhe.component.html',
    styleUrl: './formulario-detalhe.component.css'
})
export class FormularioDetalheComponent {

    backendService: BackendService;
    meuForm = new FormBuilder().group({
        idUnicoParaExemplo: [],
        documento: [],
        clienteNome: [],
        dataNascimento: [],
        contatoEmail: [],
        contatoTelefone: [],
        razaoSocial: [],
        endereco: [],
        cep: [],
        bairro: [],
        cidade: [],
        estado: [],
        inscricaoEstadual: []
    });

    /**
     *
     */
    constructor(backendService: BackendService) {
        this.backendService = backendService

    }

    onSubmit(event: Event) {
        event.preventDefault()

        this.backendService.send("texto")
        console.log(this.meuForm.get('nomes2')?.value)
    }

    onChangeButton(event: Event) {

        this.backendService.send("texto")
        console.log(event)
    }



}
