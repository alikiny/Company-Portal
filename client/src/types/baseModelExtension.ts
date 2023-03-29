import { BaseModel } from "./baseModel";

export interface BaseModelExtension extends BaseModel {
    endDate: string | null;
    version: number;
}