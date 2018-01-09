import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { Router } from '@angular/router';
import { IMyDpOptions, IMyDateModel, IMyDate } from 'mydatepicker';

import { ConferenceService } from '../api/conference.service';
import { NewConference } from '../shared/models/new-conference.model';

@Component({
  selector: 'app-register-conference',
  templateUrl: './register-conference.component.html',
  styleUrls: ['./register-conference.component.scss']
})
export class RegisterConferenceComponent implements OnInit {
  conference: NewConference = new NewConference();

  startDateTimeOptions: IMyDpOptions = {
    dateFormat: 'dd.mm.yyyy',
    showClearDateBtn: false,
    disableUntil: Object.assign({}, this.disableUntilToday)
  };
  finishDateTimeOptions: IMyDpOptions = {
    dateFormat: 'dd.mm.yyyy',
    showClearDateBtn: false,
    disableUntil: Object.assign({}, this.disableUntilToday)
  };
  startDateModel: any = { date: null };
  finishDateModel: any = { date: null };

  private get disableUntilToday(): IMyDate {
    return this.createDisableUntilDate(new Date(Date.now()));
  }

  constructor(private location: Location,
              private router: Router,
              private conferenceService: ConferenceService) { }

  ngOnInit() {
  }

  register() {
    this.conferenceService.create(this.conference)
      .subscribe((conferenceId: string) => {
        this.router.navigate(['/conference/', conferenceId]);
      });
  }

  onStartDateChanged(event: IMyDateModel) {
    this.conference.startDate = event.jsdate === null ? null : new Date(event.jsdate);
    // this.setupFinishDateRestriction();
  }

  onFinishDateChanged(event: IMyDateModel) {
    this.conference.finishDate = event.jsdate === null ? null : new Date(event.jsdate);
  }

  cancel() {
    this.location.back();
  }

  private setupFinishDateRestriction() {
    const disableUntil = this.conference.startDate === null
      ? this.disableUntilToday
      : this.createDisableUntilDate(this.conference.startDate);
    this.finishDateTimeOptions.disableUntil = disableUntil;
  }

  private createDisableUntilDate(date: Date) {
    return {
      year: date.getFullYear(),
      month: date.getMonth() + 1,
      day: date.getDate()
    };
  }
}
