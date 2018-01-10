import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import * as moment from 'moment';

import { environment } from '../../environments/environment';
import { ConferenceDetails } from '../shared/models/conference-details.model';
import { Order } from '../shared/models/order.model';
import { OrderStatus } from '../shared/enums/order-status.enum';
import { NewConference } from '../shared/models/new-conference.model';
import { SeatType } from '../shared/models/seat-type.model';
import { OrderSeat } from '../shared/models/order-seat.model';
import { Attende } from '../shared/models/attendee.model';

@Injectable()
export class ConferenceService {
  private endPoint = `${environment.endPoint}/conferences`;

  constructor(private http: HttpClient) {
  }

  locate(emial: string, accessCode: string): Observable<string> {
    const requestData = JSON.stringify({
      'email': emial,
      'accessCode': accessCode
    });

    return this.http.post(`${this.endPoint}/locate`, requestData, this.getRequestOptions())
      .map((res: any) => res.id)
      .catch(() => Observable.throw('Unable locate to conference'));
  }

  getDetails(conferenceId: string): Observable<ConferenceDetails> {
    return this.http.get(`${this.endPoint}/${conferenceId}`)
      .map((res: any) => this.convertToConferenceModel(res))
      .catch(() => Observable.throw('Unable to get conference details'));
  }

  getOrders(conferenceId: string): Observable<Order[]> {
    return this.http.get(`${this.endPoint}/${conferenceId}/orders`)
      .map((res: any) => res.map(data => this.convertToOrderModel(data)))
      .catch(() => Observable.throw('Unable to get conference orders'));
  }

  getSeatTypes(conferenceId: string): Observable<SeatType[]> {
    return this.http.get(`${this.endPoint}/${conferenceId}/seattypes`)
      .map((res: any) => res.map(data => this.convertToSeatTypeModel(data)))
      .catch(() => Observable.throw('Unable to get conference seat types'));
  }

  create(newConference: NewConference): Observable<string> {
    const requestData = JSON.stringify(newConference);

    return this.http.post(`${this.endPoint}`, requestData, this.getRequestOptions())
      .map((res: any) => res.id)
      .catch(() => Observable.throw('Unable locate to conference'));
  }

  private convertToConferenceModel(response: any): ConferenceDetails {
    return new ConferenceDetails(
      response.id,
      response.code,
      response.name,
      response.description,
      response.location,
      this.convertDate(response.startDate),
      this.convertDate(response.finishDate));
  }

  private convertToOrderModel(response: any): Order {
    const statusKey = Object.keys(OrderStatus).find(key => OrderStatus[key] === response.status);
    return new Order(
      response.id,
      response.accessCode,
      OrderStatus[statusKey],
      response.totalAmount,
      response.registrantName,
      response.registrantEmail,
      response.seats.map(seat => new OrderSeat(seat.seatInfo.name, new Attende(seat.attendee))));
  }

  private convertToSeatTypeModel(response: any): SeatType {
    return new SeatType(
      response.id,
      response.name,
      response.description,
      response.quantity,
      response.price
    );
  }

  private convertDate(date: string) {
    const utcDate = moment.utc(date, 'YYYY-MM-DD HH:mm:ss');
    return moment(utcDate).local().format('DD MMM, YYYY');
  }

  private getRequestOptions() {
    return {
      headers: new HttpHeaders({ 'Content-Type': 'application/JSON' })
    };
  }
}
