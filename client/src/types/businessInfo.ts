import { CompanyFormType } from "./company";

export interface BusinessInfo {
    businessId: string,
    name: string,
    registrationDate: string,
    companyForm: CompanyFormType,
    detailsUri: string
}

export interface Response {
    results: BusinessInfo[]
}