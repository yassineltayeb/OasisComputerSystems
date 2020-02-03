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
import { MessageService } from 'src/app/_services/message.service';
import { ClientsActiveTickets } from 'src/app/_models/clientsactivetickets';

@Component({
  selector: 'app-ticket-list',
  templateUrl: './ticket-list.component.html',
  styleUrls: ['./ticket-list.component.css']
})
export class TicketListComponent implements OnInit {
  clientsActiveTickets: ClientsActiveTickets[] = [];
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
  activeTicketColumns: any[] = [
    { columnName: 'Client ID', sortKey: '' },
    { columnName: 'Client Name', sortKey: '' },
    { columnName: 'No. of Tickets', sortKey: '' },
    { columnName: 'Account Manager', sortKey: '' }
  ];
  ticketColumns: any[] = [
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
    { columnName: 'Actions', sortKey: '' }
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
              private messageService: MessageService,
              private route: ActivatedRoute) { }

  ngOnInit() {
    this.loadToggle();
    this.getPrioritiesList();
    this.getUsersList();
    this.getTicketTypesList();
    this.getSystemModulesList();
    this.getClientsActiveTickets();

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

  // Get Clients Active Tickets
  getClientsActiveTickets() {
    this.loadToggle();

    this.ticketService.getClientsActiveTickets()
      .subscribe((res: ClientsActiveTickets[]) => {
        this.clientsActiveTickets = res;
        this.loadToggle();

      }, error => {
        this.loadToggle();
        this.alertify.error(error);

      });
  }

  // Get Ticket List
  getTicketList() {
    this.loadToggle();

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

  // Show Delete Confirm
  showDeleteConfirm(id: number) {
    this.messageService.confirmDelete('Are you sure you want to delete this client?', '', () => this.deleteTicket(id));
  }

  // Delete Ticket
  deleteTicket(id: number) {
    this.ticketService.delete(id).subscribe(res => {
      this.alertify.success('Ticket Deleted Successfully');
      this.getTicketList();
    }, error => {
      console.log(error);
      this.alertify.error(error);
    });
  }

  // Cleat Filter
  clear() {
    this.ticketParams.assignedToId = null;
    this.ticketParams.clientName = '';
    this.ticketParams.status = null;
    this.ticketParams.priorityId = null;
    this.ticketParams.ticketTypeId = null;
    this.ticketParams.systemModuleId = null;
    this.getTicketList();
  }

  // Load Toggle
  loadToggle() {
    this.loading = !this.loading;
  }

}
