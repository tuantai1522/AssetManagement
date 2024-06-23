export interface BaseResult<T> {
  isSuccess: boolean;
  result: T;
  error: {
    type: string;
    title: string;
    status: number;
    message: string;
  };
}
