import { BaseModelExtension } from "./baseModelExtension";

export interface Address extends BaseModelExtension {
    careOf: string | null;
    postCode: string | null;
    city: string | null;
    languague: string | null;
    country: string | null;
    type: AddressType;
}

export enum AddressType {
    StreetAddress = 1,
    PostalAdress = 2
}