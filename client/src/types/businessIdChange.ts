import { Source } from "./company";

export interface BusinessIdChange {
    id: string;
    source: Source;
    description: string;
    reason: string;
    changeDate: string;
    oldBusinessId: string;
    newBusinessId: string;
    language: string;
    register: number;
    change: string;
}
