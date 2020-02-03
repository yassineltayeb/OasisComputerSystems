import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NzAlertModule } from 'ng-zorro-antd/alert';
import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzBreadCrumbModule } from 'ng-zorro-antd/breadcrumb';
import { NzCardModule } from 'ng-zorro-antd/card';
import { NzCommentModule } from 'ng-zorro-antd/comment';
import { NzDividerModule } from 'ng-zorro-antd/divider';
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzFormModule } from 'ng-zorro-antd/form';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzInputModule } from 'ng-zorro-antd/input';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import { NzModalModule } from 'ng-zorro-antd/modal';
import { NzNotificationModule } from 'ng-zorro-antd/notification';
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzUploadModule } from 'ng-zorro-antd/upload';
import { NzPaginationModule } from 'ng-zorro-antd/pagination';
import { NzSelectModule } from 'ng-zorro-antd/select';
import { NZ_I18N, en_US } from 'ng-zorro-antd/i18n';
import { NzConfig, NZ_CONFIG } from 'ng-zorro-antd';
const ngZorroConfig: NzConfig = {
  message: { nzTop: 120 },
  notification: { nzPlacement: 'bottomRight' }
};

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers   : [
    { provide: NZ_I18N, useValue: en_US },
    { provide: NZ_CONFIG, useValue: ngZorroConfig }
  ],
  exports: [
    CommonModule,
    NzAlertModule,
    NzButtonModule,
    NzBreadCrumbModule,
    NzCardModule,
    NzCommentModule,
    NzDividerModule,
    NzGridModule,
    NzFormModule,
    NzIconModule,
    NzInputModule,
    NzLayoutModule,
    NzMenuModule,
    NzModalModule,
    NzNotificationModule,
    NzTableModule,
    NzUploadModule,
    NzPaginationModule,
    NzSelectModule
  ]
})

export class NGZorroModule {}
