import { Address } from "cluster";
import { CompanyName } from "./companyName";
import { Liquidation } from "./liquidation";
import { CompanyForm } from "./companyForm";
import { BusinessLine } from "./businessLine";
import { Language } from "./language";
import { RegistedOffice } from "./registedOffice";
import { ContactDetail } from "./contactDetail";
import { RegisteredEntry } from "./registeredEntry";
import { BusinessIdChange } from "./businessIdChange";

export interface Company {
    businessId: string;
    name: string;
    registrationDate: string;
    companyForm: CompanyFormType | null;
    detailsUri: string | null;
    names: CompanyName[];
    liquidations: Liquidation[] | null;
    auxiliaryNames: CompanyName[] | null;
    addresses: Address[] | null;
    companyForms: CompanyForm[] | null;
    businessLines: BusinessLine[] | null;
    languages: Language[] | null;
    registedOffices: RegistedOffice[] | null;
    contactDetails: ContactDetail[] | null;
    registeredEntries: RegisteredEntry[] | null;
    businessIdChanges: BusinessIdChange[] | null;
}

export interface CompanyResponse {
    results: Company[]
}

export enum Source {
    Common,
    Prh,
    Vero,
    Ytj
}

export enum CompanyFormType {
    OY,
    OYJ,
    OK,
    AOY,
    VOJ
}