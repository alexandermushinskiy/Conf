import { OrderStatus } from '../enums/order-status.enum';
import { OrderSeat } from './order-seat.model';

export class Order {
  constructor(public id: string,
              public accessCode: string,
              public status: OrderStatus,
              public totalAmount: string,
              public registrantName: string,
              public registrantEmail: string,
              public seats: OrderSeat[]) {
  }
}
