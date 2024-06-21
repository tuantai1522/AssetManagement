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

interface IFormInput extends FieldValues {
    firstName: string,
    lastName: string,
    dateOfBirth: Date,
    joinedDate: Date,
    gender: Gender,
    type: Type,
}

interface UserFormProps {
    onSubmit: (data: any) => void;
    isEditing?: boolean;
    isFirstNameDisabled?: boolean;
    isLastNameDisabled?: boolean;
    isDateOfBirthDisabled?: boolean;
    isGenderDisabled?: boolean;
    isJoinedDateDisabled?: boolean;
    isTypeDisabled?: boolean;
}

const UserForm = ({ 
    onSubmit,
    isEditing = false,
    isFirstNameDisabled = false,
    isLastNameDisabled = false,
    isDateOfBirthDisabled = false,
    isGenderDisabled = false,
    isJoinedDateDisabled = false,
    isTypeDisabled = false,
}: UserFormProps) => {
    const navigate = useNavigate();
    const { register, handleSubmit, control } = useForm({
        resolver: yupResolver<IFormInput>(createFormSchema),
        mode: 'all'
    });

    return (
        <div className="bg-white w-[30rem] mx-auto">
            <h2 className="text-2xl font-bold text-primary mb-5">{isEditing ? 'Edit User' : 'Create New User'}</h2>
            <form onSubmit={handleSubmit(onSubmit)} className="space-y-6">
                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">First Name</label>
                    <AppTextInput
                        id="first-name-text-field-form"
                        control={control}
                        className="grow"
                        disabled={isFirstNameDisabled}
                        {...register('firstName')}
                    />
                </div>

                <div className="flex items-center gap-5 pl-2">
                    <label className="w-[6rem]">Last Name</label>
                    <AppTextInput
                        id="last-name-text-field-form"
                        control={control}
                        className="grow"
                        disabled={isLastNameDisabled}
                        {...register('lastName')}
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
                                    disabled={isDateOfBirthDisabled}
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
                            defaultValue={Gender.Female}
                            render={({ field }) => (
                                <RadioGroup row {...field} color="warning" id="gender-radio-form">
                                    <FormControlLabel value={Gender.Female} control={<Radio sx={{ '&.Mui-checked': { color: '#cf2338' } }} />} label="Female" disabled={isGenderDisabled}/>
                                    <FormControlLabel value={Gender.Male} control={<Radio sx={{ '&.Mui-checked': { color: '#cf2338' } }} />} label="Male" disabled={isGenderDisabled}/>
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
                                    disableFuture
                                    className="grow"
                                    disabled={isJoinedDateDisabled}
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
                                        disabled={isTypeDisabled}
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
