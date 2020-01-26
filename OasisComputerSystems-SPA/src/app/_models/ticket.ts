import { Client } from './client';

export interface Ticket {
  id: number;
  clientId: number;
  Client?: Client;
  TicketNo?: number;
  priorityId: number;
  priority?: string;
  ticketTypeId: number;
  ticketType?: string;
  assignedToId: number;
  assignedTo?: string;
  systemModuleId?: number;
  systemModule?: string;
  subject?: string;
  problemDescription?: string;
  submittedById?: number;
  submittedBy?: string;
  submittedOn?: Date;
  closedById?: number;
  closedBy?: string;
  closedOn?: Date;
  approvedById?: number;
  approvedBy?: string;
  approvedOn?: Date;
  ticketNotes?: TicketNote;
}

export interface TicketNote {
  id: number;
  ticketId: number;
  notes: string;
  oasisComment: boolean;
  createdById: number;
  createdBy: string;
  createdOn: Date;
}


