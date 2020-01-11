import { Injectable } from '@angular/core';
import { NzNotificationService } from 'ng-zorro-antd/notification';

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor(private notification: NzNotificationService) {}

  // confirm(message: string, okCallback: () => any) {
  //   // tslint:disable-next-line:only-arrow-functions
  //   alertify.confirm(message, function(e) {
  //     if (e) {
  //       okCallback();
  //     } else {}
  //   });
  // }

  success(title: string, message: string = '') {
    this.notification.success(title, message);
  }

  info(title: string, message: string = '') {
    this.notification.info(title, message);
  }

  warning(title: string, message: string = '') {
    this.notification.warning(title, message);
  }

  error(title: string, message: string = '') {
    this.notification.error(title, message);
  }

  blank(title: string, message: string = '') {
    this.notification.blank(title, message);
  }

}
