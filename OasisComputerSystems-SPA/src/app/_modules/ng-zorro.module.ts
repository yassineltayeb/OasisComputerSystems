import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NzButtonModule } from 'ng-zorro-antd/button';
import { NzBreadCrumbModule } from 'ng-zorro-antd/breadcrumb';
import { NzDividerModule } from 'ng-zorro-antd/divider';
import { NzGridModule } from 'ng-zorro-antd/grid';
import { NzFormModule } from 'ng-zorro-antd/form';
import { NzIconModule } from 'ng-zorro-antd/icon';
import { NzInputModule } from 'ng-zorro-antd/input';
import { NzLayoutModule } from 'ng-zorro-antd/layout';
import { NzMenuModule } from 'ng-zorro-antd/menu';
import { NzTableModule } from 'ng-zorro-antd/table';
import { NzPaginationModule } from 'ng-zorro-antd/pagination';
import { NzSelectModule } from 'ng-zorro-antd/select';
import { NZ_I18N, en_US } from 'ng-zorro-antd/i18n';

@NgModule({
  declarations: [],
  imports: [
    CommonModule
  ],
  providers   : [
    { provide: NZ_I18N, useValue: en_US }
  ],
  exports: [
    CommonModule,
    NzButtonModule,
    NzBreadCrumbModule,
    NzDividerModule,
    NzGridModule,
    NzFormModule,
    NzIconModule,
    NzInputModule,
    NzLayoutModule,
    NzMenuModule,
    NzTableModule,
    NzPaginationModule,
    NzSelectModule
  ]
})

export class NGZorroModule {}
