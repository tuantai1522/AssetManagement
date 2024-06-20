export interface BaseResult{
    isSuccess: boolean,
    result: any,
    error: {
        type: string,
        title: string,
        status: number,
        message: string,
    }
}