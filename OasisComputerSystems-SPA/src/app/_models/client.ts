export interface Client {
  id: number;
  nameEn: string;
  nameAr: string;
  address: string;
  vATNo: string;
  telephoneNumber: string;
  countryId: number;
  country: string;
  technicalDetails: string;
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
}
