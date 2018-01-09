export class ConferenceDetails {
  constructor(public id: string,
              public accessCode: string,
              public name: string,
              public description: string,
              public location: string,
              public startDate: string,
              public finishDate: string) {
  }
}
