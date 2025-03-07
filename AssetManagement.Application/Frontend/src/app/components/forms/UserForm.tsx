import { Controller, useForm } from "react-hook-form";
import { yupResolver } from "@hookform/resolvers/yup";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { DatePicker } from '@mui/x-date-pickers/DatePicker';
import { FormControl, FormControlLabel, FormHelperText, MenuItem, Radio, RadioGroup, Select } from "@mui/material";
import { useNavigate } from "react-router-dom";
import { Gender, Type } from "../../types/enum";
import AppButton from "../buttons/Button";
import { createUserSchema } from "../../schemas/createUserSchema";
import { useEffect } from "react";
import dayjs from "dayjs";
import { UserInfoResponse } from "../../models/login/UserInfoResponse";
import { UserCreateForm } from "../../models/user/UserCreateForm";
import AppTextInput from "../AppTextInput";


interface UserFormProps {
    onSubmit: (data: any) => void;
    isEditing?: boolean;
    data?: UserInfoResponse | null;
}

const UserForm = ({
    onSubmit,
    isEditing = false,
    data,
}: UserFormProps) => {
    const navigate = useNavigate();

    const formatDate = (date: Date) => {
        return dayjs(date);
    }

    const { handleSubmit, control, getValues, trigger, reset, formState: {isValid} } = useForm({
        resolver: yupResolver<UserCreateForm>(createUserSchema),
        defaultValues: {
            gender: Gender.Female, // Set default value for gender
        },
        mode: 'all'
    });

    useEffect(() => {
        if (data && isEditing) {
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
                    <Controller
                        control={control}
                        name="firstName"
                        render={({ field }) => (
                            <AppTextInput
                                {...field}
                                id="first-name-text-field-form"
                                control={control}
                                name="firstName"
                                className={`grow ${isEditing ? 'bg-[#eff1f5] disabled pointer-events-none cursor-not-allowed' : ''}`}
                                sx={{
                                    ...(isEditing && {
                                        "& .MuiInputBase-input": {
                                            color: "#76797d"
                                        },
                                    })
                                }}
                            />
                        )}
                    />
                    
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Last Name</label>
                    <Controller
                        control={control}
                        name="lastName"
                        render={({ field }) => (
                            <AppTextInput
                                {...field}
                                id="last-name-text-field-form"
                                control={control}
                                name="lastName"
                                className={`grow ${isEditing ? 'bg-[#eff1f5] disabled pointer-events-none cursor-not-allowed' : ''}`}
                                sx={{
                                    ...(isEditing && {
                                        "& .MuiInputBase-input": {
                                            color: "#76797d"
                                        },
                                    })
                                }}
                            />
                        )}
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
                                    onChange={(date) => {
                                        field.onChange(date);
                                        if (!!getValues('joinedDate')) 
                                            trigger('joinedDate');
                                    }}
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
                                    // onChange={(e) => field.onChange(e.target.value)}
                                >
                                    <FormControlLabel value={Gender.Female} control={<Radio sx={{ '&.Mui-checked': { color: '#cf2338' } }} />} label="Female" />
                                    <FormControlLabel value={Gender.Male}  control={<Radio sx={{ '&.Mui-checked': { color: '#cf2338' } }} />} label="Male" />
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
                                        // onChange={(e) => field.onChange(e.target.value)}
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
                    <AppButton content="Save" isFormSubmit={true} isDisabled={!isValid} />
                    <AppButton content="Cancel" styleType="Secondary" onClickOn={() => {
                        navigate(-1);
                    }}
                    />
                </div>
            </form>
        </div>
    );
}

export default UserForm;
