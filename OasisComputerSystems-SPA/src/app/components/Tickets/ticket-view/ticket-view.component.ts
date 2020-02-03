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
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-ticket-view',
  templateUrl: './ticket-view.component.html',
  styleUrls: ['./ticket-view.component.css']
})
export class TicketViewComponent implements OnInit {
  ticketTypes: KeyValuePairs[] = [];
  priorities: KeyValuePairs[] = [];
  users: User[] = [];
  clients: KeyValuePairs[] = [];
  systemModules: KeyValuePairs[] = [];
  loading = false;
  ticket: Ticket = null;
  attachments: UploadFile[] = [];
  statuses: string[] = [
    'Waiting',
    'Reopened',
    'Work In Progress',
    'Pending Delivery',
    'Pending On Customer',
    'Resolved',
    'Canceled'
  ];

  @ViewChild('ticketForm', { static: false }) ticketForm: ElementRef;

  constructor(private ticketService: TicketService,
              private ticketTypeService: TicketTypeService,
              private authService: AuthService,
              private alertify: AlertifyService,
              private route: ActivatedRoute,
              private router: Router) {
    this.clear();
    this.route.params.subscribe(p => {
      if (p.id) {
        this.ticket.id = p.id;
      }
    });
  }

  ngOnInit() {
    this.getTicketTypesList();
    this.getUsersList();
    this.getTicketDetails(this.ticket.id);
    this.clear();
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

  // Get Ticket Details
  getTicketDetails(id: number) {
    if (id !== 0) {
      this.ticketService.get(this.ticket.id).subscribe((res: Ticket) => {
        this.ticket = res;
        console.log(this.ticket);
      });
    }
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

    this.ticketService.addWithFormData(formData).subscribe(() => {
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
      client:
      {
        id: 0,
        nameEn: null,
        nameAr: null,
        address: null,
        vATNo: null,
        telephoneNumber: null,
        countryId: null,
        country: null,
        technicalDetails: null
      },
      priorityId: null,
      ticketTypeId: null,
      assignedToId: null,
      clientId: null,
      systemModuleId: null,
      subject: '',
      problemDescription: '',
      ticketNotes: {
        id: null,
        ticketId: null,
        notes: null,
        oasisComment: null,
        createdById: null,
        createdBy: null,
        createdOn: null
      }
    };

  }

  loadToggle() {
    this.loading = !this.loading;
  }


}

