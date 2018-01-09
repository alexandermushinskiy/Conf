import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { ConferenceService } from '../../api/conference.service';
import { Order } from '../../shared/models/order.model';
import { OrderStatus } from '../../shared/enums/order-status.enum';

@Component({
  selector: 'app-orders',
  templateUrl: './orders.component.html',
  styleUrls: ['./orders.component.scss']
})
export class OrdersComponent implements OnInit {
  orders: Order[] = [];
  orderStatus = OrderStatus;

  constructor(private route: ActivatedRoute,
              private conferenceService: ConferenceService) {
  }

  ngOnInit() {
    this.route.parent.params
      .subscribe(params => this.getOrders(params.id));
  }

  private getOrders(conferenceId) {
    this.conferenceService.getOrders(conferenceId)
      .subscribe((res: Order[]) => {
        //debugger;
        this.orders = res;
      });
  }
}
