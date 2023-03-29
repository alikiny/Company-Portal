import { ExtensionWithSourceNLanguage } from "./extensionWithSourceNLanguage";

export interface BusinessLine extends ExtensionWithSourceNLanguage {
    order: number;
    name: string;
}