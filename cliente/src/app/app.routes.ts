import { Routes, RouterModule } from '@angular/router';
import { DoctorsComponent } from './components/doctors/doctors.component';
import { DoctorComponent } from './components/doctors/doctor.component';
import { HomeComponent } from './components/home/home.component';
import { ModulesComponent } from './components/modules/modules.component';

const app_routes: Routes = [
    { path: 'home', component: ModulesComponent },
    { path: 'doctors', component: DoctorsComponent },
    { path: 'doctor/:code', component: DoctorComponent },
    { path: '**', pathMatch: 'full', redirectTo: 'home' }
];



export const APP_ROUTING = RouterModule.forRoot(app_routes);