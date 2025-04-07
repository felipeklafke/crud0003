import { Injectable } from '@angular/core';
import { consumerPollProducersForChange } from '@angular/core/primitives/signals';

@Injectable({
  providedIn: 'root'
})
export class BackendService {

  constructor() { }


  send(texto: string){
    console.log(texto)
  }
}
