import yup from "../../app/types/yupGlobal"
import { Controller, FieldValues, useForm } from "react-hook-form"
import { yupResolver } from "@hookform/resolvers/yup"
import AppTextInput from "../../app/components/AppTextInput";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { DatePicker } from '@mui/x-date-pickers/DatePicker';
import { FormControl, FormControlLabel, FormHelperText, MenuItem, Radio, RadioGroup, Select } from "@mui/material";
import AppButton from "../../app/components/buttons/Button";
import { useNavigate } from "react-router-dom";


enum Gender {
    Male = 'Male',
    Female = 'Female',
}

enum Type {
    Staff = 'Staff',
    Admin = 'Admin',
}

interface IFormInput extends FieldValues {
    firstName: string,
    lastName: string,
    dateOfBirth: Date,
    joinedDate: Date,
    gender: Gender,
    type: Type,
}

type Props = {}

const schema = yup.object().shape({
    firstName: yup.string()
        .max(10, 'Must not exceed 10 characters long')
        .required("Please Type First Name")
        .firstName('First name must be a single word containing only alphabet letters'),
    lastName: yup.string()
        .max(30, 'Must not exceed 30 characters long')
        .required("Please Type Last Name")
        .lastName('Last name must contain only alphabet letters and spaces'),
    dateOfBirth: yup.date()
        .typeError("Invalid Date Type")
        .required("Please Select Date of Birth")
        .olderThan18('User is under 18. Please select a\ndifferent date'),
    joinedDate: yup.date()
        .required("Please Select Joined Date")
        .typeError("Invalid Date Type")
        .afterDoB('dateOfBirth', 'User under the age of 18 may not join\ncompany. Please select a different date')
        .notWeekend('Joined date is Saturday or Sunday.\nPlease select a different date'),
    gender: yup
        .mixed<Gender>()
        .defined(),
    type: yup
        .mixed<Type>()
        .required('Please Select Type')
});

const CreateUserPage = (props: Props) => {
    const navigate = useNavigate();
    const { register, handleSubmit, control } = useForm({
        resolver: yupResolver<IFormInput>(schema),
        mode: 'all'
    });

    const onSubmit = (data: any) => {
        console.log(data);
    }

    return (
        <>
            <div className="bg-white w-[30rem] mx-auto">
                <h2 className="text-2xl font-bold text-primary mb-5">Create New User</h2>
                <form onSubmit={handleSubmit(onSubmit)} className="space-y-6">
                    <div className="flex items-center gap-5 pl-2">
                        <label className="w-[6rem]">First Name</label>
                        <AppTextInput
                            id="first-name-text-field-create-form"
                            control={control}
                            className="grow"
                            {...register('firstName')}
                        />
                    </div>

                    <div className="flex items-center gap-5 pl-2">
                        <label className="w-[6rem]">Last Name</label>
                        <AppTextInput
                            id="last-name-text-field-create-form"
                            control={control}
                            className="grow"
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
                                        slotProps={{
                                            textField: {
                                                size: 'small',
                                                id: 'dateOfBirth-dpk-create-form',
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
                                defaultValue={Gender.Female} // Set default value here
                                render={({ field }) => (
                                    <RadioGroup row {...field} color="warning" id="gender-radio-create-form">
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
                                        disableFuture
                                        className="grow"
                                        slotProps={{
                                            textField: {
                                                size: 'small',
                                                id: 'joinedDate-dpk-create-form',
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
                                            id="type-selection-create-form"
                                            error={!!error}
                                        >
                                            <MenuItem value={Type.Staff}>Staff</MenuItem>
                                            <MenuItem value={Type.Admin}>Admin</MenuItem>
                                        </Select>
                                        {error && (
                                            <FormHelperText id="type-select-error" sx={{ color: "#d32f2f"}}>{error.message}</FormHelperText>
                                        )}
                                    </FormControl>
                                )}
                            />
                        </div>
                    </div>

                    <div className="flex justify-end space-x-4">
                        <AppButton content="Save" isFormSubmit={true} />
                        <AppButton content="Cancel" styleType="Secondary" onClickOn={() => {navigate('/manage-user')}} />
                    </div>
                </form>
            </div>
        </>
    )
}

export default CreateUserPage