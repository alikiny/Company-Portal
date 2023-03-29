import { BaseModelExtension } from "./baseModelExtension";
import { Source } from "./company";

export interface ExtensionWithSourceNLanguage extends BaseModelExtension {
    language: string;
    source: Source;
}