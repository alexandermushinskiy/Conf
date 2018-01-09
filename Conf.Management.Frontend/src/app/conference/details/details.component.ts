import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { ConferenceService } from '../../api/conference.service';
import { ConferenceDetails } from '../../shared/models/conference-details.model';

@Component({
  selector: 'app-conf-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.scss']
})
export class ConferenceDetailsComponent implements OnInit {
  conference: ConferenceDetails;

  constructor(private route: ActivatedRoute,
              private conferenceService: ConferenceService) {
  }

  ngOnInit() {
    this.route.params
      .subscribe(params => this.getConferenceDetails(params.id));
  }

  private getConferenceDetails(conferenceId) {
    this.conferenceService.getDetails(conferenceId)
      .subscribe((res: ConferenceDetails) => this.conference = res);
  }

}
