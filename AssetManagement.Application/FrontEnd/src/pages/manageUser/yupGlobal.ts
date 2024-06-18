import * as yup from 'yup';

// Regular expressions for validation
const REGEX_FIRST_NAME = /^[a-zA-Z]+$/; // Only contains alphabet letters
const REGEX_LAST_NAME = /^[a-zA-Z\s]+$/; // Contains multiple words with alphabet letters only

// Adding custom methods to yup
yup.addMethod(yup.string, 'firstName', function (message: string) {
  return this.matches(REGEX_FIRST_NAME, {
    message,
    excludeEmptyString: true,
  });
});

yup.addMethod(yup.string, 'lastName', function (message: string) {
  return this.matches(REGEX_LAST_NAME, {
    message,
    excludeEmptyString: true,
  });
});

yup.addMethod(yup.date, 'olderThan', function (age: number, message: string) {
  return this.test('older-than', message, function (value) {
    if (!value) return false;
    const birthDate = new Date(value);
    const today = new Date();
    const ageDate = new Date(today.getFullYear() - age, today.getMonth(), today.getDate());
    return birthDate <= ageDate;
  });
});

yup.addMethod(yup.date, 'notWeekend', function (message) {
  return this.test('notWeekend', message, function (value) {
    if (!value) return false;
    const day = new Date(value).getDay();
    // getDay() returns 0 for Sunday and 6 for Saturday
    return day !== 0 && day !== 6;
  });
});

yup.addMethod(yup.date, 'afterDoB', function (refField: string, message: string) {
  return this.test('after', message, function (value) {
    const { parent } = this;
    const refValue = parent[refField];
    if (!value || !refValue) return false;
    const refDate = new Date(refValue);
    const joinedDate = new Date(refDate.getFullYear() + 18, refDate.getMonth(), refDate.getDate());
    return value > joinedDate;
  });
});

export default yup;

