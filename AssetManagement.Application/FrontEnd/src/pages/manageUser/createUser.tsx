import yup from "../../app/types/yupGlobal"
import { Controller, FieldValues, useForm } from "react-hook-form"
import { yupResolver } from "@hookform/resolvers/yup"
import AppTextInput from "../../app/components/AppTextInput";
import { AdapterDayjs } from '@mui/x-date-pickers/AdapterDayjs';
import { LocalizationProvider } from '@mui/x-date-pickers/LocalizationProvider';
import { DatePicker } from '@mui/x-date-pickers/DatePicker';
import { FormControl, FormControlLabel, FormLabel, MenuItem, Radio, RadioGroup, Select, TextField, colors } from "@mui/material";
import AppButton from "../../app/components/buttons/Button";

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
        .max(10, 'must not exceed 10 characters long')
        .required("Please Type First Name")
        .firstName('First name must be a single word containing only alphabet letters'),
    lastName: yup.string()
        .max(30, 'must not exceed 30 characters long')
        .required("Please Type Last Name")
        .lastName('Last name must contain only alphabet letters and spaces'),
    dateOfBirth: yup.date()
        .required("Please Pick Date of Birth")
        .olderThan18('User is under 18. Please select a\ndifferent date'),
    joinedDate: yup.date()
        .required("Please Pick Joined Date")
        .afterDoB('dateOfBirth', 'User under the age of 18 may not join\ncompany. Please select a different date')
        .notWeekend('Joined date is Saturday or Sunday.\nPlease select a different date'),
    gender: yup
        .mixed<Gender>()
        .defined()
        .oneOf(Object.values(Gender)),
    type: yup
        .mixed<Type>()
        .required('Please Select Type')
        .oneOf(Object.values(Type))
});

const CreateUserPage = (props: Props) => {
    const { register, handleSubmit, control } = useForm({ resolver: yupResolver<IFormInput>(schema), mode: 'all' });

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
                            {/* <DatePicker className="grow" /> */}
                            <Controller
                                control={control}
                                name="dateOfBirth"
                                render={({ field }) => (
                                    <DatePicker
                                        {...field}
                                        className="grow"
                                        slotProps={{
                                            textField: {
                                                size: 'small',
                                                id: 'dateOfBirth-dpk-create-form',
                                            }
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
                                    <RadioGroup row {...field} color="warning">
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
                            {/* <DatePicker className="grow" /> */}
                            <Controller
                                control={control}
                                name="joinedDate"
                                render={({ field }) => (
                                    <DatePicker
                                        {...field}
                                        className="grow"
                                        slotProps={{
                                            textField: {
                                                size: 'small',
                                                id: 'joinedDate-dpk-create-form',
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
                                render={({ field }) => (
                                    <FormControl fullWidth>
                                        <Select
                                            size="small"
                                            {...field}
                                            id="type-select"
                                            inputProps={{ 'aria-label': 'Without label' }}
                                        >
                                            <MenuItem value={Type.Staff}>Staff</MenuItem>
                                            <MenuItem value={Type.Admin}>Admin</MenuItem>
                                        </Select>
                                    </FormControl>
                                )}
                            />
                        </div>
                    </div>

                    <div className="flex justify-end space-x-4">
                        {/* <button type="submit" className="bg-red-600 text-white py-2 px-4 rounded">Save</button>
                        <button type="button" className="bg-gray-200 py-2 px-4 rounded">Cancel</button> */}
                        <AppButton content="Save" isFormSubmit={true}/>
                        <AppButton content="Cancel" styleType="Secondary" onClickOn={() => {}}/>
                    </div>
                </form>
            </div>
        </>
    )
}

export default CreateUserPage