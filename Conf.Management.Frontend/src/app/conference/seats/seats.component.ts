import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { SeatType } from '../../shared/models/seat-type.model';
import { ConferenceService } from '../../api/conference.service';
import { SeatTypeService } from '../../api/seat-type.service';

@Component({
  selector: 'app-seats',
  templateUrl: './seats.component.html',
  styleUrls: ['./seats.component.scss']
})
export class SeatsComponent implements OnInit {
  seatTypes: SeatType[] = [];

  constructor(private route: ActivatedRoute,
              private conferenceService: ConferenceService,
              private seatTypeService: SeatTypeService) { }

  ngOnInit() {
    this.route.parent.params
      .subscribe(params => this.getSeatTypes(params.id));
  }

  private getSeatTypes(conferenceId: string) {
    this.seatTypeService.getSeatTypes(conferenceId)
      .subscribe((res: SeatType[]) => {
        this.seatTypes = res;
      });
  }

}
