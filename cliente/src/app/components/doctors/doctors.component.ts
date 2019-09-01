import { Component } from '@angular/core';
import { DoctorsService } from 'src/app/services/doctors.service';
import { Doctor } from '../../models/doctor';

@Component({
  selector: 'app-doctors',
  templateUrl: './doctors.component.html'
})
export class DoctorsComponent {

  doctors: Doctor[] = [];
  loading:boolean = true;

  constructor( private _doctorsService: DoctorsService ) {
    this._doctorsService.getDoctors()
    .subscribe((data: any) => {
        this.doctors = data;
        this.loading= false;
        console.log(this.doctors);
    });
  }

  deleteDoctor(key$: string){
    this._doctorsService.deleteDoctor(key$)
      .subscribe( (data:any) => {
        if (data) {
          console.log('se borro papito')
          this.doctors=data;
          //buscar una soluciona mas elegante
          this._doctorsService.refreshDoctors();
          
            
        }else{        
          console.error(data);
        }
      })

  }
}
