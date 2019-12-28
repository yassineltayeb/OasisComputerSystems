import { AuthGuard } from './_quard/auth.guard';
import { Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { ClientListComponent } from './components/clients/client-list/client-list.component';
import { HomeComponent } from './components/home/home.component';
import { TicketListComponent } from './components/Tickets/ticket-list/ticket-list.component';

export const appRoutes: Routes = [
    { path: 'login', component: LoginComponent },
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children: [
            { path: 'home', component: HomeComponent },
            {
                path: 'clients', component: ClientListComponent,
                // resolve: {users: MemberListResolver}
            },
            {
                path: 'tickets', component: TicketListComponent,
                // resolve: {users: MemberListResolver}
            },
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
