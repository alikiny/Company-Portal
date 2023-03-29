import { BaseModelExtension } from "./baseModelExtension";
import { Company, Source } from "./company";

export interface CompanyName extends BaseModelExtension {
    order: number;
    name: string;
    source: Source;
}