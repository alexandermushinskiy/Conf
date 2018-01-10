import { Attende } from './attendee.model';

export class OrderSeat {
  constructor(public name: string,
              public attendee: Attende) {
  }
}
