import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { DoctorsComponent } from '../components/doctors/doctors.component';
import { Doctor } from '../models/doctor';


@Injectable({
  providedIn: 'root'
})
export class DoctorsService {

  formData: DoctorsComponent;
  doctorsURL = 'https://localhost:44390/api/doctor/';
  lista: any[];

  constructor(private http: HttpClient) {
    console.log('Doctor Service Listo');
  }

  getDoctors() {
    return this.http.get(this.doctorsURL);
  }

  getDoctor(key$: string) {
    return this.http.get(`${this.doctorsURL}${ key$}`);
  }

//   refreshDoctor(key$: string){
//      this.http.get(`${this.doctorsURL}${ key$}`)
//      .toPromise()
//      .then()
//   }

  refreshDoctors(){
    this.http.get(this.doctorsURL)
    .toPromise()
      .then((res:any) => {
      this.lista=res;
      console.log(this.lista);
    });

    // this._doctorsService.getDoctors()
    // .subscribe((data: any) => {
    //     this.doctors = data;
    //     console.log(this.doctors);
    // });
 }

  postDoctor( doctor: Doctor ) {
    const reqHeader = new HttpHeaders().set('Content-Type', 'application/json')
       .set('Accept', 'application/json');
    return this.http.post(this.doctorsURL, doctor,  { headers: reqHeader });
  }

  putDoctor(key$: string, doctor: Doctor ) {
    const reqHeader = new HttpHeaders().set('Content-Type', 'application/json')
       .set('Accept', 'application/json');
    return this.http.put(`${this.doctorsURL}${ key$}`, doctor,  { headers: reqHeader });
  }

  deleteDoctor(key$: string){
    const reqHeader = new HttpHeaders().set('Content-Type', 'application/json')
       .set('Accept', 'application/json');
    return this.http.delete (`${this.doctorsURL}${ key$}`, { headers: reqHeader });
  }
}
