import { BaseModel } from "./baseModel";

export interface RegisteredEntry extends BaseModel {
    endDate: string;
    statusDate: string;
    language: string;
    authority: Authority;
    status: Status;
    register: Register;
    description: string;
}

export enum Authority {
    Vero = 1,
    Prh = 2,
    Dvv = 3
}

export enum Register {
    Trade = 1,
    Foundation,
    Association,
    Tax,
    Prepayment,
    VAT,
    Employer = 7,
    Other
}

export enum Status {
    Common,
    Unregistered,
    Registered
}