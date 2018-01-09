import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { ConferenceService } from '../api/conference.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  email = 'info@researchfora.com';
  accessCode = 'ASDFG';

  constructor(private conferenceService: ConferenceService,
              private router: Router,
              private route: ActivatedRoute) { }

  ngOnInit() {
  }

  login() {
    this.conferenceService.locate(this.email, this.accessCode)
      .subscribe(
        res => this.onSuccess(res),
        err => this.onError(err));
  }

  private onSuccess(conferenceId) {
    this.router.navigate(['/conference/', conferenceId]);
  }

  private onError(err) {
    console.log(err);
  }
}
