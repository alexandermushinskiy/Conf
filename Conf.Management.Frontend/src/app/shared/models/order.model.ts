import { OrderStatus } from '../enums/order-status.enum';

export class Order {
  constructor(public id: string,
              public accessCode: string,
              public status: OrderStatus,
              public totalAmount: string,
              public registrantName: string,
              public registrantEmail: string) {
  }
}
