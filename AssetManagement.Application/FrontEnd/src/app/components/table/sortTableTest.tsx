import * as React from 'react';
import Box from '@mui/material/Box';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import TableSortLabel from '@mui/material/TableSortLabel';
import { visuallyHidden } from '@mui/utils';

import { ArrowDropDown, ArrowDropUp } from '@mui/icons-material';

//Data 
interface Data {
    id: number;
    calories: number;
    carbs: number;
    fat: number;
    name: string;
    protein: number;
    [key: string]: any;
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

function descendingComparator<T>(a: T, b: T, orderBy: keyof T) {
    if (b[orderBy] < a[orderBy]) {
        return -1;
    }
    if (b[orderBy] > a[orderBy]) {
        return 1;
    }
    return 0;
}

type Order = 'asc' | 'desc';

function getComparator<Key extends keyof Data>(
    order: Order,
    orderBy: Key
  ): (a: Data, b: Data) => number {
    return order === 'desc'
      ? (a, b) => descendingComparator(a, b, orderBy)
      : (a, b) => -descendingComparator(a, b, orderBy);
  }

// Since 2020 all major browsers ensure sort stability with Array.prototype.sort().
// stableSort() brings sort stability to non-modern browsers (notably IE11). If you
// only support modern browsers you can replace stableSort(exampleArray, exampleComparator)
// with exampleArray.slice().sort(exampleComparator)
function stableSort<T>(array: readonly T[], comparator: (a: T, b: T) => number) {
    const stabilizedThis = array.map((el, index) => [el, index] as [T, number]);
    stabilizedThis.sort((a, b) => {
        const order = comparator(a[0], b[0]);
        if (order !== 0) {
            return order;
        }
        return a[1] - b[1];
    });
    return stabilizedThis.map((el) => el[0]);
}

function modernSort<T>(array: readonly T[], comparator: (a: T, b: T) => number): T[] {
    return array.slice().sort(comparator);
}

interface HeadCell {
    disablePadding: boolean;
    id: any;
    label: string;
    fieldName: string;
    numeric: boolean;
    className?: string;
    classNames?: string[];
    style?: any;
    disableSort?: boolean,
    rowRatio?: string,
}

const headCells: readonly HeadCell[] = [
    {
        id: 'name',
        numeric: true,
        fieldName: "name",
        disablePadding: true,
        label: 'Dessert (100g serving)',
        className: "font-bold",
        rowRatio: "w-3/12",
        style: {
            // textDecoration: "underline",
            border: "none",
            borderBottom: "none"
        }
    },
    {
        id: 'calories',
        fieldName: 'calories',
        numeric: true,
        disablePadding: false,
        label: 'Calories',
        className: "font-bold",
        style: {
            // textDecoration: "underline",
            border: "none",
            borderBottom: "none"
        },
        disableSort: true,
        rowRatio: "w-2/12",
    },
    {
        id: 'fat',
        fieldName: 'fat',
        numeric: true,
        disablePadding: false,
        label: 'Fat (g)',
        className: "font-bold ",
        style: {
            // textDecoration: "underline",
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-2/12",
    },
    {
        id: 'protein',
        fieldName: 'protein',
        numeric: true,
        disablePadding: false,
        label: 'Protein (g)',
        className: "font-bold ",
        style: {
            // textDecoration: "underline",
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-3/12",
    },
    {
        id: 'carbs',
        fieldName: 'carbs',
        numeric: true,
        disablePadding: false,
        label: 'Carbs (g)',
        className: "font-bold ",
        style: {
            // textDecoration: "underline",
            border: "none",
            borderBottom: "none"
        },
        rowRatio: "w-2/12",
    },
    
];

interface EnhancedTableProps {
    numSelected: number;
    onRequestSort: (event: React.MouseEvent<unknown>, property: keyof Data) => void;
    order: Order;
    orderBy: any;
    rowCount: number;
}

function EnhancedTableHead(props: EnhancedTableProps) {
    const { order, orderBy, onRequestSort } =
        props;
    const createSortHandler =
        (property: keyof Data) => (event: React.MouseEvent<unknown>) => {
            onRequestSort(event, property);
        };

    return (
        <TableHead>
            <TableRow >
                {headCells.map((headCell) => (
                    <TableCell
                        key={headCell.id}
                        align="left"
                        padding={headCell.disablePadding ? 'none' : 'normal'}
                        sortDirection={orderBy === headCell.id ? order : false}
                        className='font-bold'
                    >
                        <TableSortLabel
                            active={orderBy === headCell.id}
                            direction={orderBy === headCell.id ? order : 'asc'}
                            onClick={createSortHandler(headCell.id)}
                            IconComponent={ArrowDropDown}
                            className={`font-bold ${headCell.className}`}
                            // className='font-bold'
                            sx={headCell.style}
                            disabled={headCell.disableSort ?? false}
                        >
                            {headCell.label}
                            {orderBy === headCell.id ? (
                                <Box component="span" sx={visuallyHidden}>
                                    {order === 'desc' ? 'sorted descending' : 'sorted ascending'}
                                </Box>
                            ) : null}
                        </TableSortLabel>
                    </TableCell>
                ))}
            </TableRow>
        </TableHead>
    );
}

export default function EnhancedTable() {
    const [order, setOrder] = React.useState<Order>('desc');
    const [orderBy, setOrderBy] = React.useState<any>('fat');
    const [selected, setSelected] = React.useState<readonly number[]>([]);
    const [page, setPage] = React.useState(0);
    const [rowsPerPage, setRowsPerPage] = React.useState(15);

    const handleRequestSort = (
        event: React.MouseEvent<unknown>,
        property: any,
    ) => {
        const isAsc = orderBy === property && order === 'asc';
        setOrder(isAsc ? 'desc' : 'asc');
        setOrderBy(property);
    };

    const handleClick = (event: React.MouseEvent<unknown>, id: number) => {
        const selectedIndex = selected.indexOf(id);
        let newSelected: readonly number[] = [];

        if (selectedIndex === -1) {
            newSelected = newSelected.concat(selected, id);
        } else if (selectedIndex === 0) {
            newSelected = newSelected.concat(selected.slice(1));
        } else if (selectedIndex === selected.length - 1) {
            newSelected = newSelected.concat(selected.slice(0, -1));
        } else if (selectedIndex > 0) {
            newSelected = newSelected.concat(
                selected.slice(0, selectedIndex),
                selected.slice(selectedIndex + 1),
            );
        }
        setSelected(newSelected);
    };

    const isSelected = (id: number) => selected.indexOf(id) !== -1;

    // Avoid a layout jump when reaching the last page with empty rows.
    // const emptyRows =
    //     page > 0 ? Math.max(0, (1 + page) * rowsPerPage - rows.length) : 0;

    const visibleRows = React.useMemo(
        () =>
            stableSort(rows, getComparator(order, orderBy)).slice(
                page * rowsPerPage,
                page * rowsPerPage + rowsPerPage,
            ),
        [order, orderBy, page, rowsPerPage],
    );

    return (
        <Box sx={{ width: '100%' }}>
            <TableContainer sx={{ width: '100%', mb: 2 }} >
                <Table
                    sx={{
                        minWidth: 800,
                        borderCollapse: 'separate',
                        borderSpacing: '20px 0',
                        '& td, & th': {
                            borderColor: 'transparent',
                            borderBottom: "1px solid grey",
                            paddingLeft: 0,
                            paddingRight: 0,
                        },

                        "& thead tr th": {
                            borderBottom: "1px solid black",
                            fontWeight: "bold"
                        }
                    }}
                    aria-labelledby="tableTitle"
                    size={"small"}
                >
                    <EnhancedTableHead
                        numSelected={selected.length}
                        order={order}
                        orderBy={orderBy}
                        onRequestSort={handleRequestSort}
                        rowCount={rows.length}
                    />
                    <TableBody>
                        {visibleRows.map((row, index) => {
                            const isItemSelected = isSelected(row.id);
                            // const labelId = `enhanced-table-checkbox-${index}`;

                            return (<>
                                <TableRow
                                    hover
                                    onClick={(event) => handleClick(event, row.id)}
                                    // role="checkbox"
                                    aria-checked={isItemSelected}
                                    tabIndex={-1}
                                    key={row.id}
                                    selected={isItemSelected}
                                    sx={{ cursor: 'pointer' }}
                                >
                                    {headCells.map((head, index) => {
                                        const fieldName = head.fieldName;
                                        const value = row[fieldName];

                                        return (
                                            <TableCell
                                                align="left"
                                                className={head.rowRatio ?? ""}
                                                key={index}
                                            >
                                                {value}
                                            </TableCell>
                                        );
                                    })}
                                </TableRow>
                            </>
                            );
                        })}
                        {/* {emptyRows > 0 && (
                            <TableRow
                                style={{
                                    height: (dense ? 33 : 53) * emptyRows,
                                }}
                            >
                                <TableCell colSpan={6} />
                            </TableRow>
                        )} */}
                    </TableBody>
                </Table>
            </TableContainer>
            {/* <TablePagination
          rowsPerPageOptions={[5, 10, 25]}
          component="div"
          count={rows.length}
          rowsPerPage={rowsPerPage}
          page={page}
          onPageChange={handleChangePage}
          onRowsPerPageChange={handleChangeRowsPerPage}
        /> */}
        </Box>
    );
}