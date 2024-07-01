import * as yup from 'yup';
import dayjs from 'dayjs';

// Regular expressions for validation
const REGEX_ALPHABET = /^[a-zA-Z]+$/; // Only contains alphabet letters
const REGEX_ALPHABET_AND_NUMBER = /^[a-zA-Z0-9]+$/; // Only contains alphabet letters and numbers
const REGEX_ALPHABET_AND_WHITE_SPACE = /^[a-zA-Z\s]+$/; // Contains multiple words with alphabet letters only
const REGEX_ALPHABET_NUMBER_AND_WHITE_SPACE = /^[a-zA-Z0-9\s]+$/; // Contains multiple words with alphabet letters and numbers
// Regular expressions for validation
// const REGEX_FIRST_NAME = /^[\p{L}]+$/u; // Contains Vietnamese letters
// const REGEX_LAST_NAME = /^[\p{L}\s]+$/u; // Contains Vietnamese letters


// Adding custom methods to yup
yup.addMethod(yup.string, 'firstName', function (message: string) {
  return this.matches(REGEX_ALPHABET, {
    message,
    excludeEmptyString: true,
  });
});

yup.addMethod(yup.string, 'lastName', function (message: string) {
  return this.matches(REGEX_ALPHABET_AND_WHITE_SPACE, {
    message,
    excludeEmptyString: true,
  });
});

yup.addMethod(yup.string, 'categoryName', function (message: string) {
  return this.matches(REGEX_ALPHABET_NUMBER_AND_WHITE_SPACE, {
    message,
    excludeEmptyString: true,
  });
});

yup.addMethod(yup.string, 'categoryPrefix', function (message: string) {
  return this.matches(REGEX_ALPHABET_AND_NUMBER, {
    message,
    excludeEmptyString: true,
  });
});

// Method to check if date is older than 18 years
yup.addMethod(yup.date, 'olderThan18', function (message) {
  return this.test('older-than', message, function (value) {
    if (!value) return false;
    const age = 18;
    const birthDate = dayjs(value);
    const today = dayjs();
    const ageDate = today.subtract(age, 'year');
    return birthDate.isBefore(ageDate, 'day');
  });
});

// Method to check if date is not on a weekend
yup.addMethod(yup.date, 'notWeekend', function (message) {
  return this.test('notWeekend', message, function (value) {
    if (!value) return false;
    const day:number = dayjs(value).day();
    // day() returns 0 for Sunday and 6 for Saturday
    return day !== 0 && day !== 6;
  });
});

// Method to check if date is after a specific reference date
yup.addMethod(yup.date, 'afterDoB', function (refField, message) {
  return this.test('afterDoB', message, function (value, context) {
    const { parent } = context;
    const refValue = parent[refField];
    const refDate = dayjs(refValue);
    const joinedDate = refDate.add(18, 'year');
    return dayjs(value).isAfter(joinedDate, 'day');
  });
});

// Method to check if date is after a specific reference date
yup.addMethod(yup.date, 'requireDoB', function (refField, message) {
  return this.test('requireDoB', message, function (value, context) {
    const { parent } = context;
    const refValue = parent[refField];
    if (!refValue || !dayjs(refValue).isValid()) return false;
    return true;
  });
});

export default yup;

