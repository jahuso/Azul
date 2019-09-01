import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ModulesComponent } from '../components/modules/modules.component';
// import { Module } from '../models/module';


@Injectable({
  providedIn: 'root'
})
export class ModuleService {


  modulesURL = 'https://localhost:44390/api/module/';



  constructor(private http: HttpClient) { 
    console.log('Module Service Listo');
  }

  getModules(){
    return this.http.get(this.modulesURL);
  }


}
