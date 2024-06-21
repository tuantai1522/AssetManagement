import { Controller, FieldValues, useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { DatePicker } from '@mui/x-date-pickers/DatePicker';
import { FormControl, FormControlLabel, FormHelperText, MenuItem, Radio, RadioGroup, Select } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Gender, Type } from "../../types/enum";
import AppTextInput from "../AppTextInput";
import AppButton from "../buttons/Button";
import { createFormSchema } from "../../schemas/createFormSchema";
import { UserInfoResponse } from "../../models/response/UserInfoResponse";
import { useEffect } from "react";
import dayjs from "dayjs";

interface IFormInput extends FieldValues {
    firstName: string,
    lastName: string,
    dateOfBirth: Date,
    joinedDate: Date,
    gender: string,
    type: string,
}

interface UserFormProps {
    onSubmit: (data: any) => void;
    isEditing?: boolean;
    data?: UserInfoResponse;
}

const UserForm = ({
    onSubmit,
    isEditing = false,
    data
}: UserFormProps) => {
    const navigate = useNavigate();

    const formatDate = (date: Date) => {
        return dayjs(date);
    }

    const { handleSubmit, control, reset } = useForm({
        resolver: yupResolver<IFormInput>(createFormSchema),
        mode: 'all'
    });

    useEffect(() => {
        if (data && isEditing) {
            console.log('data: ', data)
            reset({
                firstName: data.firstName,
                lastName: data.lastName,
                dateOfBirth: formatDate(data.dateOfBirth),
                joinedDate: formatDate(data.joinedDate),
                gender: data.gender,
                type: data.type,
            });
        }
    }, [data, reset]);
    
    return (
        <div className="bg-white w-[30rem] mx-auto">
            <h2 className="text-2xl font-bold text-primary mb-5">{isEditing ? 'Edit User' : 'Create New User'}</h2>
            <form onSubmit={handleSubmit(onSubmit)} className="space-y-6">
                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">First Name</label>
                    <AppTextInput
                        id="first-name-text-field-form"
                        control={control}
                        value={data ? data.firstName : undefined}
                        className={`grow ${isEditing ? 'bg-[#eff1f5] disabled pointer-events-none cursor-not-allowed' : ''}`}
                        sx={{
                            "& .MuiInputBase-input": {
                              color: "#76797d", 
                            },
                          }}
                        name="firstName"
                    />
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Last Name</label>
                    <AppTextInput
                        id="last-name-text-field-form"
                        control={control}
                        value={data ? data.lastName : undefined}
                        className={`grow ${isEditing ? 'bg-[#eff1f5] disabled pointer-events-none cursor-not-allowed' : ''}`}
                        sx={{
                            "& .MuiInputBase-input": {
                              color: "#76797d", 
                            },
                          }}
                        name="lastName"
                    />
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Date of Birth</label>
                    <LocalizationProvider dateAdapter={AdapterDayjs}>
                        <Controller
                            control={control}
                            name="dateOfBirth"
                            render={({ field, fieldState: { error } }) => (
                                <DatePicker
                                    {...field}
                                    format="DD/MM/YYYY"
                                    disableFuture
                                    className="grow"
                                    value={data ? formatDate(data.dateOfBirth) : undefined}
                                    slotProps={{
                                        textField: {
                                            size: 'small',
                                            id: 'dateOfBirth-dpk-form',
                                            helperText: error ? error.message : '',
                                            error: !!error
                                        },
                                    }}
                                />
                            )}
                        />
                    </LocalizationProvider>
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Gender</label>
                    <div className="grow">
                        <Controller
                            control={control}
                            name="gender"
                            render={({ field }) => (
                                <RadioGroup
                                    row {...field}
                                    color="warning"
                                    id="gender-radio-form"
                                    value={field.value || Gender.Female} // Ensure a default value is set if field.value is undefined
                                    onChange={(e) => field.onChange(e.target.value)}
                                >
                                    <FormControlLabel value={Gender.Female} control={<Radio sx={{ '&.Mui-checked': { color: '#cf2338' } }} />} label="Female" /> 
                                    <FormControlLabel value={Gender.Male} control={<Radio sx={{ '&.Mui-checked': { color: '#cf2338' } }} />} label="Male" />
                                </RadioGroup>
                            )}
                        />
                    </div>
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Joined Date</label>
                    <LocalizationProvider dateAdapter={AdapterDayjs}>
                        <Controller
                            control={control}
                            name="joinedDate"
                            render={({ field, fieldState: { error } }) => (
                                <DatePicker
                                    {...field}
                                    format="DD/MM/YYYY"
                                    className="grow"
                                    value={data ? formatDate(data.joinedDate) : undefined}
                                    slotProps={{
                                        textField: {
                                            size: 'small',
                                            id: 'joinedDate-dpk-form',
                                            helperText: error ? error.message : '',
                                            error: !!error
                                        }
                                    }}
                                />
                            )}
                        />
                    </LocalizationProvider>
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Type</label>
                    <div className="grow">
                        <Controller
                            control={control}
                            name="type"
                            render={({ field, fieldState: { error } }) => (
                                <FormControl fullWidth>
                                    <Select
                                        size="small"
                                        {...field}
                                        id="type-selection-form"
                                        error={!!error}
                                        value={field.value || ''} 
                                        onChange={(e) => field.onChange(e.target.value)}
                                    >
                                        <MenuItem value={Type.Staff}>Staff</MenuItem> 
                                        <MenuItem value={Type.Admin}>Admin</MenuItem>
                                    </Select>
                                    {error && (
                                        <FormHelperText id="type-select-error" sx={{ color: "#d32f2f" }}>{error.message}</FormHelperText>
                                    )}
                                </FormControl>
                            )}
                        />
                    </div>
                </div>

                <div className="flex justify-end space-x-4">
                    <AppButton content="Save" isFormSubmit={true} />
                    <AppButton content="Cancel" styleType="Secondary" onClickOn={() => { navigate('/manage-user') }} />
                </div>
            </form>
        </div>
    );
}

export default UserForm;
