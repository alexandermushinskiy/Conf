export class Attende {
  email: string;
  firstName: string;
  lastName: string;

  constructor(data: any) {
    Object.assign(this, data);
  }

  // constructor(public email: string,
  //             public firstName: string,
  //             public lastName: string) {
  // }
}
