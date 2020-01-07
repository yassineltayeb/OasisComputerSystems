import { Injectable } from '@angular/core';
import { NzNotificationService } from 'ng-zorro-antd/notification';

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  constructor(private notification: NzNotificationService) {
    this.notification.config({
      nzPlacement: 'bottomRight'
    });
  }

  // confirm(message: string, okCallback: () => any) {
  //   // tslint:disable-next-line:only-arrow-functions
  //   alertify.confirm(message, function(e) {
  //     if (e) {
  //       okCallback();
  //     } else {}
  //   });
  // }

  success(message: string) {
    this.notification.success(message, '');
  }

  info(message: string) {
    this.notification.info(message, '');
  }

  warning(message: string) {
    this.notification.warning(message, '');
  }

  error(message: string) {
    this.notification.error(message, '');
  }

  blank(message: string) {
    this.notification.blank(message, '');
  }

}
