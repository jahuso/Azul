import { Component, OnInit } from '@angular/core';
import { Doctor } from 'src/app/models/doctor';
import { DoctorsService } from 'src/app/services/doctors.service';
import { Router, ActivatedRoute } from '@angular/router';
import { NgForm, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-doctor',
  templateUrl: './doctor.component.html'
})
export class DoctorComponent {

  forma: FormGroup;

  doctor: Doctor = {

    code: "",
    idNumber: "",
    name: "",
    mobilePhone: "",
    mail: ""
  }

  new:boolean = false;
  code: any;

  constructor(private _doctorsService: DoctorsService,
    private router: Router,
    private route: ActivatedRoute ) {


    this.route.params
      .subscribe( parametros => {
        this.code = parametros['code'];
        if (this.code !== 'new' ) {
          this._doctorsService.getDoctor(this.code)
            .subscribe( res => {
              this.doctor= res;
            },
            err => {
              console.log(err);
            }
          );
        }
    })
  }

  addNew(forma: NgForm){
    this.router.navigate(['/doctor', 'new']);
    forma.reset();
  }

  createDoctor(forma: NgForm){
    console.log(this.code);
    if (this.code =='new') {
      this._doctorsService.postDoctor(forma.value)
    .subscribe(
      res => {
        this.resetForm(forma);
      },
      error => {
        console.log(error);
      }
    );
    } else{
      forma.value['code'] = this.code;
      this._doctorsService.putDoctor(this.code, forma.value)
        .subscribe( data => {
          this.resetForm(forma);
        },  
        error => {
          console.error(error)
        });
    }
  }

  resetForm(form?: NgForm) {
    form.resetForm();
  }

  
}
