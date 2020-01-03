import { Component, OnInit } from '@angular/core';
import { Client } from 'src/app/_models/client';
import { ClientService } from 'src/app/_services/client.service';
import { Pagination, PaginatedResult } from 'src/app/_models/pagination';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrls: ['./client-list.component.css']
})
export class ClientListComponent implements OnInit {
  clients: Client[] = [];
  pagination: Pagination;
  PageSizeOptions: any[] = [5, 10, 20, 30, 40, 50, 100];
  loading = false;
  clientParams: any = {
    orderBy: 'nameEn',
    IsOrderAscending: true,
    pageNumber: 1,
    itemsPerPage: 10
  };
  columns: any[] = [
    { columnName: 'ID', sortKey: 'id' },
    { columnName: 'Name (En)', sortKey: 'nameEn' },
    { columnName: 'Name (Ar)', sortKey: 'nameAr' },
    { columnName: 'Address', sortKey: 'address' },
    { columnName: 'Vat No.', sortKey: 'vATNo' },
    { columnName: 'Telephone No.', sortKey: 'telephoneNumber' },
    { columnName: 'Country', sortKey: 'country' },
    { columnName: 'Technical Details', sortKey: 'technicalDetails' },
    { columnName: 'Created By', sortKey: 'createdBy' },
    { columnName: 'Created On', sortKey: 'createdOn' },
    { columnName: 'Updated By', sortKey: 'updatedBy' },
    { columnName: 'Updated On', sortKey: 'updatedOn' }
  ];

  constructor(private clientService: ClientService, private route: ActivatedRoute, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadToggle();

    this.route.data.subscribe(data => {
      this.clients = data.clients.result;
      this.pagination = data.clients.pagination;
      this.loadToggle();
    });
  }

  pageChanged(event: any, eventType: string): void {
    if (eventType === 'PageIndexChange') {
      this.clientParams.pageNumber = event;
    } else {
      this.clientParams.itemsPerPage = event;
    }
    this.getClientList();
  }

  getClientList() {
    this.loadToggle();

    this.clientService.getAll(this.clientParams)
      .subscribe((res: PaginatedResult<Client[]>) => {
        this.clients = res.result;
        this.pagination = res.pagination;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  sort(event: { key: any; value: string; }) {
    this.clientParams.orderBy = event.key;
    this.clientParams.IsOrderAscending = event.value === 'ascend' ? true : false;
    this.getClientList();
  }

  loadToggle() {
    this.loading = !this.loading;
  }

}
