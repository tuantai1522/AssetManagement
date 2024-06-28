// types/yup.d.ts
import { DateSchema, StringSchema } from 'yup';

declare module 'yup' {
  interface StringSchema {
    firstName(message: string): this;
    lastName(message: string): this;
    categoryName(message: string): this;
    categoryPrefix(message: string): this;
  }

  interface DateSchema {
    olderThan18(message: string): this;
    notWeekend(message: string): this;
    afterDoB(refField: string, message: string): this;
    requireDoB(refField: string, message: string): this;
  }
}
