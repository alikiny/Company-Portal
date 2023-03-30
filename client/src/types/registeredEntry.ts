import { BaseModel } from "./baseModel";

export interface RegisteredEntry extends BaseModel {
    endDate: string;
    statusDate: string;
    language: string;
    authority: Authority;
    status: Status;
    register: number;
    description: string;
}

export enum Authority {
    Vero = 1,
    Prh = 2,
    Dvv = 3
}

export enum Status {
    Common,
    Unregistered,
    Registered
}