import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

import { environment } from '../../environments/environment';
import { SeatType } from '../shared/models/seat-type.model';

@Injectable()
export class SeatTypeService {
  private endPoint = `${environment.endPoint}/conferences`;

  constructor(private http: HttpClient) {
  }

  getSeatTypes(conferenceId: string): Observable<SeatType[]> {
    return this.http.get(`${this.endPoint}/${conferenceId}/seattypes`)
      .map((res: any) => res.map(data => this.convertToSeatTypeModel(data)))
      .catch(() => Observable.throw('Unable to get conference seat types'));
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
}
