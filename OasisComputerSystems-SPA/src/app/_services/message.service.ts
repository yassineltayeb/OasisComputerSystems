import { Injectable } from '@angular/core';
import { NzModalService } from 'ng-zorro-antd/modal';

@Injectable({
  providedIn: 'root'
})
export class MessageService {

  constructor(private modalService: NzModalService) { }

  confirm(title: string, content: string = '', OnOk) {
    this.modalService.confirm({
      nzTitle: title,
      nzContent: content,
      nzOnOk: OnOk()
    });
  }

  confirmDelete(title: string, content: string = '', OnOk) {
    this.modalService.confirm({
      nzTitle: title,
      nzContent: content,
      nzOkText: 'Yes',
      nzOkType: 'danger',
      nzCancelText: 'No',
      nzOnOk: OnOk
    });
  }

}
