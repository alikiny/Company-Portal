import { ExtensionWithSourceNLanguage } from "./extensionWithSourceNLanguage";

export interface Language extends ExtensionWithSourceNLanguage {
    name: string;
    order: number;
}