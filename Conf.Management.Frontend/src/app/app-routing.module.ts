import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { LoginComponent } from './login/login.component';
import { ConferenceComponent } from './conference/conference/conference.component';
import { OrdersComponent } from './conference/orders/orders.component';
import { SeatsComponent } from './conference/seats/seats.component';
import { ConferenceDetailsComponent } from './conference/details/details.component';
import { RegisterConferenceComponent } from './register-conference/register-conference.component';

const appRoutes: Routes = [
  { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'conference/:id', component: ConferenceComponent,
    children: [
      { path: '', component: ConferenceDetailsComponent },
      { path: 'orders', component: OrdersComponent },
      { path: 'seats', component: SeatsComponent }
    ]
  },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterConferenceComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
