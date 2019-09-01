import { Component, OnInit } from '@angular/core';
import { ModuleService } from 'src/app/services/module.service';
import { Module } from '../../models/module';


@Component({
  selector: 'app-modules',
  templateUrl: './modules.component.html'
})
export class ModulesComponent  {

  modules: Module[] = [];
  loading:boolean = true;

  constructor( private _modulesService:ModuleService) { 
   this._modulesService.getModules()
     .subscribe((data:any) => {
       this.modules = data;
       this.loading= false;
        console.log(this.modules);
     })   

  }


}
