const getUtcOffset = (): number => {
  const now = new Date();
  const utcOffset = now.getTimezoneOffset() / -60;
  return utcOffset;
};

export const convertUtcToLocalDate = (
  dateTime: Date | null | undefined
): string | null => {
  if (!dateTime) {
    return null;
  }

  const utcOffset = getUtcOffset();
  const localTime = new Date(
    new Date(dateTime).getTime() + utcOffset * 60 * 60 * 1000
  );

  const dayString = String(localTime.getDate()).padStart(2, "0");
  const monthString = String(localTime.getMonth() + 1).padStart(2, "0");
  const yearString = localTime.getFullYear();

  const result = `${dayString}/${monthString}/${yearString}`;

  return result;
};

export const convertDateToString = (
  dateTime: Date | null | undefined
): string | null => {
  if (!dateTime) {
    return null;
  }

  const localTime = new Date(
    new Date(dateTime).getTime()
  );

  const dayString = String(localTime.getDate()).padStart(2, "0");
  const monthString = String(localTime.getMonth() + 1).padStart(2, "0");
  const yearString = localTime.getFullYear();

  const result = `${dayString}/${monthString}/${yearString}`;

  return result;
};
