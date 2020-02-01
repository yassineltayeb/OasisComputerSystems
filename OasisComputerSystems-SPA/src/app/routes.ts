import { AuthGuard } from './_quard/auth.guard';
import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { ClientListComponent } from './components/clients/client-list/client-list.component';
import { HomeComponent } from './components/home/home.component';
import { TicketListComponent } from './components/Tickets/ticket-list/ticket-list.component';
import { ClientListResolver } from './_resolvers/client-list.resolver';
import { ClientNewComponent } from './components/clients/client-new/client-new.component';
import { TicketNewComponent } from './components/Tickets/ticket-new/ticket-new.component';
import { TicketListResolver } from './_resolvers/ticket-list.resolver';

export const appRoutes: Routes = [
    { path: '', component: LoginComponent },
    { path: 'login', component: LoginComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'home', component: HomeComponent },
            {
                path: 'clients', component: ClientListComponent,
                resolve: { clients: ClientListResolver }
            },
            { path: 'clients/new', component: ClientNewComponent },
            { path: 'clients/:id', component: ClientNewComponent },
            {
                path: 'tickets', component: TicketListComponent,
                resolve: { tickets: TicketListResolver }
            },
            { path: 'tickets/new', component: TicketNewComponent },
            { path: 'tickets/:id', component: TicketNewComponent },
            // {
            //     path: 'member/edit', component: MemberEditComponent,
            //     resolve: {user: MemberEditResolver},
            //     canDeactivate: [ PreventUnsavedChanges ]
            // },
            // {
            //     path: 'member/:id', component: MemberDetailComponent,
            //     resolve: {user: MemberDetailResolver}
            // },
            // { path: 'lists', component: ListsComponent },
            // { path: 'messages', component: MessagesComponent },
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full' }
];
