import { useState } from "react";
import AppTable, { ColumnDefinition, Order } from "./sortTable";


interface Data {
    id: number;
    calories: number;
    carbs: number;
    fat: number;
    name: string;
    protein: number;
}

function createData(
    id: number,
    name: string,
    calories: number,
    fat: number,
    carbs: number,
    protein: number,
): Data {
    return {
        id,
        name,
        calories,
        fat,
        carbs,
        protein,
    };
}

const rows = [
    createData(1, 'Cupcake', 305, 3.7, 67, 4.3),
    createData(2, 'Donut', 452, 25.0, 51, 4.9),
    createData(3, 'Eclair', 262, 16.0, 24, 6.0),
    createData(4, 'Frozen yoghurt', 159, 6.0, 24, 4.0),
    createData(5, 'Gingerbread', 356, 16.0, 49, 3.9),
    createData(6, 'Honeycomb', 408, 3.2, 87, 6.5),
    createData(7, 'Ice cream sandwich', 237, 9.0, 37, 4.3),
    createData(8, 'Jelly Bean', 375, 0.0, 94, 0.0),
    createData(9, 'KitKat', 518, 26.0, 65, 7.0),
    createData(10, 'Lollipop', 392, 0.2, 98, 0.0),
    createData(11, 'Marshmallow', 318, 0, 81, 2.0),
    createData(12, 'Nougat', 360, 19.0, 9, 37.0),
    createData(13, 'Oreo', 437, 18.0, 63, 4.0),
];


const columns: ColumnDefinition[] = [
    {
        id: 'name',
        fieldName: "name",
        disablePadding: true,
        label: 'Dessert (100g serving)',
        className: "font-bold",
        rowRatio: "w-3/12",
        style: {
            border: "none",
            borderBottom: "none"
        }
    },
    {
        id: 'calories',
        fieldName: 'calories',
        disablePadding: false,
        label: 'Calories',
        className: "font-bold",
        style: {
            border: "none",
            borderBottom: "none"
        },
        disableSort: true,
        rowRatio: "w-2/12",
    },
    {
        id: 'fat',
        fieldName: 'fat',
        disablePadding: false,
        label: 'Fat (g)',
        className: "font-bold ",
        style: {
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-2/12",
    },
    {
        id: 'protein',
        fieldName: 'protein',
        disablePadding: false,
        label: 'Protein (g)',
        className: "font-bold ",
        style: {
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-3/12",
    },
    {
        id: 'carbs',
        fieldName: 'carbs',
        disablePadding: false,
        label: 'Carbs (g)',
        className: "font-bold ",
        style: {
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-2/12",
    },

];

export default function TestSortComponent() {

    const [order, setOrder] = useState<Order>("desc");
    const [orderBy, setOrderBy] = useState<string>("fat");

    return (
        <>
            <AppTable<Data>
                order={order}
                setOrder={setOrder}
                orderByFieldName={orderBy}
                setOrderByFieldName={setOrderBy}
                columns={columns}
                rows={rows}
                handleClick={() => { }}
            />
        </>
    );
}
