import { Component, OnInit } from '@angular/core';
import { CountryService } from 'src/app/_services/country.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { KeyValuePairs } from 'src/app/_models/keyvaluepairs';
import { ClientService } from 'src/app/_services/client.service';
import { SystemModuleService } from 'src/app/_services/system-module.service';
import { Client, ClientContact, ClientContactSupport } from 'src/app/_models/client';

@Component({
  selector: 'app-client-new',
  templateUrl: './client-new.component.html',
  styleUrls: ['./client-new.component.css']
})
export class ClientNewComponent implements OnInit {
  countries: KeyValuePairs[] = [];
  systemsModules: KeyValuePairs[] = [];
  loading = false;
  client: Client = null;
  clientModules: any[] = [];
  clientContacts: ClientContact = {
    name: null,
    position: null,
    phone: null,
    email: null
  };
  clientContactSupport: ClientContactSupport = {
    name: null,
    position: null,
    phone: null,
    email: null
  };
  selectedModule = null;

  constructor(private clientService: ClientService,
              private countryService: CountryService,
              private systemModuleService: SystemModuleService,
              private alertify: AlertifyService) { }

  ngOnInit() {
    this.getCountriesList();
    this.getSystemsModulesList();
    this.clear();
  }

  // Get Countries List
  getCountriesList() {
    this.countryService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.countries = res;

      }, error => {
        this.alertify.error(error);

      });
  }

  // Get System Modules
  getSystemsModulesList() {
    this.systemModuleService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.systemsModules = res;

      }, error => {
        this.alertify.error(error);

      });
  }

  // Save Client
  save() {
    this.clientService.add(this.client).subscribe(res => {
      this.alertify.success('Client Saved Successfully');
      this.clear();

    }, error => {
      console.log(error);
      this.alertify.error(error);

    });
  }

  // Clear Form
  clear() {
    this.client = {
      id: 0,
      nameEn: '',
      nameAr: '',
      address: '',
      vATNo: '',
      telephoneNumber: '',
      countryId: null,
      country: '',
      technicalDetails: '',
      clientsModules: [],
      clientContacts: [],
      clientContactSupports: []
    };

    this.clearClientContact();
    this.clearClientContactSupport();
  }

  // Load Toggle
  loadToggle() {
    this.loading = !this.loading;
  }

  // Add Module
  addModule() {
    if (!this.clientModules.includes(this.selectedModule)) {
      this.clientModules.push(this.selectedModule);
      this.client.clientsModules.push({ systemModuleId: this.selectedModule.id });
    }

    this.selectedModule = null;
  }

  // Delete Module
  deleteModule(clientModule) {
    this.clientModules.splice(this.clientModules.indexOf(clientModule), 1);
    this.client.clientsModules.splice(this.client.clientsModules.indexOf(clientModule.id), 1);
    this.selectedModule = null;
  }

  // Add Client Contact
  addClientContact() {
    if (!this.client.clientContacts.includes(this.clientContacts)) {
      this.client.clientContacts.push(
        {
          name: this.clientContacts.name,
          position: this.clientContacts.position,
          phone: this.clientContacts.phone,
          email: this.clientContacts.email,
        }
      );
    }

    this.clearClientContact();

  }

  // Delete Client Contact
  deleteClientContact(clientContact) {
    this.client.clientContacts.splice(this.client.clientContacts.indexOf(clientContact), 1);
  }

  // Add Client Contact Support
  addClientContactSupport() {
    if (!this.client.clientContactSupports.includes(this.clientContactSupport)) {
      this.client.clientContactSupports.push(
        {
          name: this.clientContactSupport.name,
          position: this.clientContactSupport.position,
          phone: this.clientContactSupport.phone,
          email: this.clientContactSupport.email,
        }
      );
    }

    this.clearClientContactSupport();

  }

  // Delete Client Contact Support
  deleteClientContactSupport(clientContactSupport) {
    this.client.clientContactSupports.splice(this.client.clientContactSupports.indexOf(clientContactSupport), 1);
  }

  // Clear Client Contact
  clearClientContact() {
    this.clientContacts = {
      name: '',
      position: '',
      phone: '',
      email: ''
    };
  }

  // Clear Client Contact Support
  clearClientContactSupport() {
    this.clientContactSupport = {
      name: '',
      position: '',
      phone: '',
      email: ''
    };
  }

  // Validate Client Contact
  validateClientContact() {
    if ((this.clientContacts.name == null || this.clientContacts.name === '') ||
        (this.clientContacts.position == null || this.clientContacts.position === '') ||
        (this.clientContacts.phone == null || this.clientContacts.phone === '') ||
        (this.clientContacts.email == null || this.clientContacts.email === '')) {
      return false;
    }

    return true;
  }

  // Validate Client Contact Support
  validateClientContactSupport() {
    if ((this.clientContactSupport.name == null || this.clientContactSupport.name === '') ||
        (this.clientContactSupport.position == null || this.clientContactSupport.position === '') ||
        (this.clientContactSupport.phone == null || this.clientContactSupport.phone === '') ||
        (this.clientContactSupport.email == null || this.clientContactSupport.email === '')) {
      return false;
    }

    return true;
  }


}
