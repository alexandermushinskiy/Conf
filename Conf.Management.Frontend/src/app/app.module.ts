import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { MyDatePickerModule } from 'mydatepicker';
import 'rxjs/Rx';

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { ConferenceDetailsComponent } from './conference/details/details.component';
import { SeatsComponent } from './conference/seats/seats.component';
import { OrdersComponent } from './conference/orders/orders.component';
import { LoginComponent } from './login/login.component';
import { AppRoutingModule } from './app-routing.module';
import { ConferenceService } from './api/conference.service';
import { HttpClientModule } from '@angular/common/http';
import { ConferenceComponent } from './conference/conference/conference.component';
import { RegisterConferenceComponent } from './register-conference/register-conference.component';
import { SeatTypeService } from './api/seat-type.service';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    ConferenceDetailsComponent,
    SeatsComponent,
    OrdersComponent,
    LoginComponent,
    ConferenceComponent,
    RegisterConferenceComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule,
    HttpClientModule,
    AppRoutingModule,
    MyDatePickerModule
  ],
  providers: [
    ConferenceService,
    SeatTypeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
