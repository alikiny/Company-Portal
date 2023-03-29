import { ExtensionWithSourceNLanguage } from "./extensionWithSourceNLanguage";

export interface RegistedOffice extends ExtensionWithSourceNLanguage {
    name: string;
    order: number;
}