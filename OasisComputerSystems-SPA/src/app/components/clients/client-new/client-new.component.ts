import { Component, OnInit } from '@angular/core';
import { CountryService } from 'src/app/_services/country.service';
import { AlertifyService } from 'src/app/_services/alertify.service';
import { KeyValuePairs } from 'src/app/_models/keyvaluepairs';
import { NzNotificationService } from 'ng-zorro-antd/notification';
import { ClientService } from 'src/app/_services/client.service';

@Component({
  selector: 'app-client-new',
  templateUrl: './client-new.component.html',
  styleUrls: ['./client-new.component.css']
})
export class ClientNewComponent implements OnInit {
  countries: KeyValuePairs[] = [];
  loading = false;
  client: any = {};

  constructor(private clientService: ClientService, private countryService: CountryService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.getCountriesList();
  }

  getCountriesList() {

    this.countryService.getAll()
      .subscribe((res: KeyValuePairs[]) => {
        this.countries = res;
        console.log(this.countries);

      }, error => {
        this.alertify.error(error);

      });
  }

  save() {
    console.log(this.client);
    this.alertify.success('Client Saved Successfully');
  }

  clear() {
    this.client = {};
  }

  loadToggle() {
    this.loading = !this.loading;
  }

}
