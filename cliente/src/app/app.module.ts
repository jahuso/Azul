import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { DoctorsComponent } from './components/doctors/doctors.component';
import { DoctorComponent } from './components/doctors/doctor.component';
import { NavbarComponent } from './components/shared/navbar/navbar.component';
import { HomeComponent } from './components/home/home.component';

import { DoctorsService } from './services/doctors.service';
import { APP_ROUTING } from './app.routes';
import { KeysPipe } from './pipes/keys.pipe';
import { ModulesComponent } from './components/modules/modules.component';


@NgModule({
  declarations: [
    AppComponent,
    DoctorsComponent,
    DoctorComponent,
    NavbarComponent,
    HomeComponent,
    KeysPipe,
    ModulesComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    APP_ROUTING
  ],
  providers: [
    DoctorsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
