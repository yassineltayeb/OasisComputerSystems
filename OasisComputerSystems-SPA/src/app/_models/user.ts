export interface User {
  id: number;
  username: string;
  Status: string;
  FullNameEn: string;
  FullNameAr: string;
  createdById: number;
  createdBy: string;
  createdOn: Date;
  updatedById?: number;
  updatedBy?: string;
  updatedOn?: Date;
  isDeleted?: boolean;
  deletedById?: number;
  deletedBy?: string;
  deletedOn?: Date;
  clientsModules?: ClientsModules[];
}

interface ClientsModules {
  systemModuleId: number;
}

