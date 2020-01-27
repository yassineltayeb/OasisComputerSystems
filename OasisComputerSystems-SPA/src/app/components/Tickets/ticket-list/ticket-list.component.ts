import { Component, OnInit } from '@angular/core';
import { Ticket } from 'src/app/_models/ticket';
import { TicketService } from 'src/app/_services/ticket.service';
import { ActivatedRoute } from '@angular/router';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { PaginatedResult, Pagination } from 'src/app/_models/pagination';
import { PriorityService } from 'src/app/_services/priority.service';
import { KeyValuePairs } from 'src/app/_models/keyvaluepairs';
import { AuthService } from 'src/app/_services/auth.service';
import { User } from 'src/app/_models/user';
import { TicketTypeService } from 'src/app/_services/ticket-type.service';
import { SystemModuleService } from 'src/app/_services/system-module.service';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
  tickets: Ticket[] = [];
  users: User[] = [];
  priorities: KeyValuePairs[] = [];
  ticketTypes: KeyValuePairs[] = [];
  systemModules: KeyValuePairs[] = [];
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
  statuses: string[] = [
    'Waiting',
    'Reopened',
    'Work In Progress',
    'Pending Delivery',
    'Pending On Customer',
    'Resolved',
    'Canceled'
  ];


  constructor(private ticketService: TicketService,
              private priorityService: PriorityService,
              private authService: AuthService,
              private ticketTypeService: TicketTypeService,
              private systemModuleService: SystemModuleService,
              private alertify: AlertifyService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    this.loadToggle();
    this.getPrioritiesList();
    this.getUsersList();
    this.getTicketTypesList();
    this.getSystemModulesList();

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

  // Get Priorities
  getPrioritiesList() {
    this.loadToggle();

    this.priorityService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.priorities = res;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  // Get Users
  getUsersList() {
    this.loadToggle();

    this.authService.getAll()
      .subscribe((res: User[]) => {
        this.users = res;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  // Get Ticket Types
  getTicketTypesList() {
    this.loadToggle();

    this.ticketTypeService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.ticketTypes = res;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  // Get System Modules
  getSystemModulesList() {
    this.loadToggle();

    this.systemModuleService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.systemModules = res;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
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
    this.ticketParams.assignedToId = null;
    this.ticketParams.clientName = '';
    this.ticketParams.status = null;
    this.ticketParams.priorityId = null;
    this.ticketParams.ticketTypeId = null;
    this.ticketParams.systemModuleId = null;
    this.getTicketList();
  }

  loadToggle() {
    this.loading = !this.loading;
  }

}
