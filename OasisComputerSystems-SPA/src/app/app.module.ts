import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { JwtModule } from '@auth0/angular-jwt';
import { appRoutes } from './routes';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule, PaginationModule } from 'ngx-bootstrap';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './components/nav/nav.component';
import { ClientService } from './_services/client.service';
import { AlertifyService } from './_services/alertify.service';
import { HomeComponent } from './components/home/home.component';
import { ClientListComponent } from './components/clients/client-list/client-list.component';
import { TicketListComponent } from './components/Tickets/ticket-list/ticket-list.component';
import { ClientListResolver } from './_resolvers/client-list.resolver';
import { ClientNewComponent } from './components/clients/client-new/client-new.component';
import { NGZorroModule } from './_modules/ng-zorro.module';
import { CountryService } from './_services/country.service';
import { SystemModuleService } from './_services/system-module.service';
import { TicketService } from './_services/ticket.service';
import { TicketNewComponent } from './components/Tickets/ticket-new/ticket-new.component';
import { TicketListResolver } from './_resolvers/ticket-list.resolver';
import { MessageService } from './_services/message.service';


export function tokenGetter() {
   return localStorage.getItem('token');
}

@NgModule({
   declarations: [
      AppComponent,
      LoginComponent,
      NavComponent,
      HomeComponent,
      ClientListComponent,
      ClientNewComponent,
      TicketListComponent,
      TicketNewComponent
   ],
   imports: [
      BrowserModule,
      BrowserAnimationsModule,
      HttpClientModule,
      FormsModule,
      ReactiveFormsModule,
      AppRoutingModule,
      NGZorroModule,
      RouterModule.forRoot(appRoutes),
      PaginationModule.forRoot(),
      BsDropdownModule.forRoot(),
      JwtModule.forRoot({
         config: {
            // tslint:disable-next-line:object-literal-shorthand
            tokenGetter: tokenGetter,
            whitelistedDomains: ['localhost:5000'],
            blacklistedRoutes: ['localhost:5000/api/auth']
         }
      })
   ],
   providers: [
      AlertifyService,
      CountryService,
      ClientService,
      ClientListResolver,
      MessageService,
      SystemModuleService,
      TicketService,
      TicketListResolver
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
