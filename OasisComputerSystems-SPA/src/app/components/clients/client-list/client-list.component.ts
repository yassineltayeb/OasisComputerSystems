import { Component, OnInit } from '@angular/core';
import { Client } from 'src/app/_models/client';
import { ClientService } from 'src/app/_services/client.service';
import { Pagination, PaginatedResult } from 'src/app/_models/pagination';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { ActivatedRoute } from '@angular/router';
import { KeyValuePairs } from 'src/app/_models/keyvaluepairs';
import { CountryService } from 'src/app/_services/country.service';
import { MessageService } from 'src/app/_services/message.service';

@Component({
  selector: 'app-client-list',
  templateUrl: './client-list.component.html',
  styleUrls: ['./client-list.component.css']
})
export class ClientListComponent implements OnInit {
  countries: KeyValuePairs[] = [];
  clients: Client[] = [];
  pagination: Pagination;
  PageSizeOptions: any[] = [5, 10, 20, 30, 40, 50, 100];
  loading = false;
  clientParams: any = {
    name: '',
    countryId: null,
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
    { columnName: 'Updated On', sortKey: 'updatedOn' },
    { columnName: 'Actions', sortKey: '' }
  ];

  constructor(
    private countryService: CountryService,
    private clientService: ClientService,
    private route: ActivatedRoute,
    private alertify: AlertifyService,
    private messageService: MessageService) { }

  ngOnInit() {
    this.loadToggle();

    this.route.data.subscribe(data => {
      this.clients = data.clients.result;
      this.pagination = data.clients.pagination;
      this.loadToggle();
    });

    this.getCountriesList();

  }

  pageChanged(event: any, eventType: string): void {
    if (eventType === 'PageIndexChange') {
      this.clientParams.pageNumber = event;
    } else {
      this.clientParams.itemsPerPage = event;
    }
    this.getClientsList();
  }

  getCountriesList() {
    this.loadToggle();

    this.countryService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.countries = res;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  getClientsList() {
    this.loadToggle();

    this.clientService.getAllWithPagination(this.clientParams)
      .subscribe((res: PaginatedResult<Client[]>) => {
        this.clients = res.result;
        this.pagination = res.pagination;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  showDeleteConfirm(id: number) {
    this.messageService.confirmDelete('Are you sure you want to delete this client?', '', () => this.deleteClient(id));
  }

  deleteClient(id: number) {
    this.clientService.delete(id).subscribe(res => {
      this.alertify.success('Client Deleted Successfully');
      this.getClientsList();
    }, error => {
      console.log(error);
      this.alertify.error(error);
    });
  }

  sort(event: { key: any; value: string; }) {
    this.clientParams.orderBy = event.key;
    this.clientParams.IsOrderAscending = event.value === 'ascend' ? true : false;
    this.getClientsList();
  }

  clear() {
    this.clientParams.name = null;
    this.clientParams.countryId = null;
    this.getClientsList();
  }

  loadToggle() {
    this.loading = !this.loading;
  }

}
