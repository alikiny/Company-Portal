import { ExtensionWithSourceNLanguage } from "./extensionWithSourceNLanguage";

export interface ContactDetail extends ExtensionWithSourceNLanguage {
    value: string;
    type: string;
}