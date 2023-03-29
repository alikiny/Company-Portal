import { Source } from "./company";
import { Register } from "./registeredEntry";

export interface BusinessIdChange {
    id: string;
    source: Source;
    description: string;
    reason: string;
    changeDate: string;
    oldBusinessId: string;
    newBusinessId: string;
    language: string;
    register: Register;
    change: Change;
}

export enum Change {
    Removal = 2,
    Combine = 3,
    IDChanged = 5,
    Fusion = 44,
    ContinueVAT = 45,
    Predecesssor = 46,
    Division = 47,
    Bankruptcy = 48,
    PrivateTrader = 49,
    PartialDivision = 57
}