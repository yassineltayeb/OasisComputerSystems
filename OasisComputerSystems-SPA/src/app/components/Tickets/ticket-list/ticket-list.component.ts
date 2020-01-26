import { Component, OnInit } from '@angular/core';
import { Ticket } from 'src/app/_models/ticket';
import { TicketService } from 'src/app/_services/ticket.service';
import { ActivatedRoute } from '@angular/router';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { PaginatedResult, Pagination } from 'src/app/_models/pagination';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
  tickets: Ticket[] = [];
  pagination: Pagination;
  PageSizeOptions: any[] = [5, 10, 20, 30, 40, 50, 100];
  ticketParams: any = {
    orderBy: 'ticketNo',
    IsOrderAscending: true,
    pageNumber: 1,
    itemsPerPage: 10
  };
  loading = false;
  columns: any[] = [
    { columnName: 'Assigned To', sortKey: 'assignedTo' },
    { columnName: 'No.', sortKey: 'ticketNo' },
    { columnName: 'Status', sortKey: 'status' },
    { columnName: 'Priority', sortKey: 'priority' },
    { columnName: 'Type', sortKey: 'ticketType' },
    { columnName: 'Client Name', sortKey: 'clientName' },
    { columnName: 'Module', sortKey: 'systemModule' },
    { columnName: 'Subject', sortKey: 'subject' },
    { columnName: 'Problem Description', sortKey: 'problemDescription' },
    { columnName: 'Reminder(s)', sortKey: 'reminders' },
    { columnName: 'Submitted By', sortKey: 'submittedBy' },
    { columnName: 'Submitted On', sortKey: 'submittedOn' },
    { columnName: 'Closed By', sortKey: 'closedBy' },
    { columnName: 'Closed On', sortKey: 'closedOn' }
  ];


  constructor(private ticketService: TicketService,
              private route: ActivatedRoute,
              private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadToggle();

    this.route.data.subscribe(data => {
      this.tickets = data.tickets.result;
      this.pagination = data.tickets.pagination;
      this.loadToggle();
    });
  }

  pageChanged(event: any, eventType: string): void {
    if (eventType === 'PageIndexChange') {
      this.ticketParams.pageNumber = event;
    } else {
      this.ticketParams.itemsPerPage = event;
    }
    this.getTicketList();
  }

  sort(event: { key: any; value: string; }) {
    this.ticketParams.orderBy = event.key;
    this.ticketParams.IsOrderAscending = event.value === 'ascend' ? true : false;
    this.getTicketList();
  }

  getTicketList() {
    this.loadToggle();

    console.log(this.ticketParams);

    this.ticketService.getAllWithPagination(this.ticketParams)
      .subscribe((res: PaginatedResult<Ticket[]>) => {
        this.tickets = res.result;
        console.log(this.tickets);
        this.pagination = res.pagination;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  clear() {

  }

  loadToggle() {
    this.loading = !this.loading;
  }

}
