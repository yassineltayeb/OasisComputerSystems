import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import { KeyValuePairs } from 'src/app/_models/keyvaluepairs';
import { PriorityService } from 'src/app/_services/priority.service';
import { TicketTypeService } from 'src/app/_services/ticket-type.service';
import { ClientService } from 'src/app/_services/client.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { AuthService } from 'src/app/_services/auth.service';
import { User } from 'src/app/_models/user';
import { Ticket } from 'src/app/_models/ticket';
import { SystemModuleService } from 'src/app/_services/system-module.service';
import { TicketService } from 'src/app/_services/ticket.service';
import { UploadFile } from 'ng-zorro-antd/upload';
import { Router } from '@angular/router';

@Component({
  selector: 'app-ticket-new',
  templateUrl: './ticket-new.component.html',
  styleUrls: ['./ticket-new.component.css']
})
export class TicketNewComponent implements OnInit {
  ticketTypes: KeyValuePairs[] = [];
  priorities: KeyValuePairs[] = [];
  users: User[] = [];
  clients: KeyValuePairs[] = [];
  systemModules: KeyValuePairs[] = [];
  loading = false;
  ticket: Ticket = null;
  attachments: UploadFile[] = [];


  @ViewChild('ticketForm', {static: false}) ticketForm: ElementRef;


  constructor(
    private ticketService: TicketService,
    private priorityService: PriorityService,
    private ticketTypeService: TicketTypeService,
    private clientService: ClientService,
    private systemModuleService: SystemModuleService,
    private authService: AuthService,
    private alertify: AlertifyService,
    private router: Router) { }

  ngOnInit() {
    this.getPrioritiesList();
    this.getTicketTypesList();
    this.getUsersList();
    this.getClientsList();
    this.getSystemModulesList();
    this.clear();
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

  // Get Clients
  getClientsList() {
    this.loadToggle();

    this.clientService.getAllClients()
      .subscribe((res: KeyValuePairs[]) => {
        this.clients = res;
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

  loadToggle() {
    this.loading = !this.loading;
  }

  // Save
  save() {
    this.loadToggle();
    // tslint:disable-next-line:prefer-const
    let formData: FormData = new FormData();
    formData.append('priorityId', this.ticket.priorityId.toString());
    formData.append('ticketTypeId', this.ticket.ticketTypeId.toString());
    formData.append('assignedToId', this.ticket.assignedToId.toString());
    formData.append('clientId', this.ticket.clientId.toString());
    formData.append('systemModuleId', this.ticket.systemModuleId.toString());
    formData.append('subject', this.ticket.subject);
    formData.append('problemDescription', this.ticket.problemDescription);

    this.attachments.forEach((file: any) => {
      formData.append('attachments', file);
      console.log(file);
    });

    this.ticketService.addWithFormData(formData).subscribe(res => {
      this.loadToggle();
      this.alertify.success('Ticket Saved Successfully');
      this.router.navigate(['/tickets']);

    }, error => {
      console.log(error);
      this.alertify.error(error);

    });
  }

  beforeUpload = (file: UploadFile): boolean => {
    this.attachments = this.attachments.concat(file);
    return false;
  }

  // Clear Form
  clear() {
    this.ticket = {
      id: 0,
      priorityId: null,
      ticketTypeId: null,
      assignedToId: null,
      clientId: null,
      systemModuleId: null,
      subject: '',
      problemDescription: ''
    };

  }

}
