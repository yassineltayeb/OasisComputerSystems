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
  clientParams: any = {
    orderBy: 'nameEn',
    IsOrderAscending: true,
    pageNumber: 1,
    itemsPerPage: 10
  };

  constructor(private clientService: ClientService, private route: ActivatedRoute, private alertify: AlertifyService) { }

  ngOnInit() {
    this.route.data.subscribe(data => {
      this.clients = data.clients.result;
      console.log(this.clients);
      this.pagination = data.clients.pagination;
    });
  }

  pageChanged(event: any): void {
    this.clientParams.pageNumber = event.page;
    this.getClientList();
  }

  getClientList() {
    this.clientService.getAll(this.clientParams)
      .subscribe((res: PaginatedResult<Client[]>) => {
      this.clients = res.result;
      this.pagination = res.pagination;

    }, error => {
      this.alertify.error(error);
    });
  }

}
