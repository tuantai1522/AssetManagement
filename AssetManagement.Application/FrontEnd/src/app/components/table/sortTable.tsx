import { ArrowDropDown } from "@mui/icons-material";
import { Box, Table, TableBody, TableCell, TableContainer, TableHead, TableRow, TableSortLabel } from "@mui/material";
import { visuallyHidden } from '@mui/utils';

export interface CustomTableHeadProp {
    onRequestSort: (event: React.MouseEvent<unknown>, property: any) => void;
    order: Order;
    orderBy: any;
    columns: ColumnDefinition[]
}
export type Order = 'asc' | 'desc';
export interface ColumnDefinition {
    disablePadding?: boolean;
    id: any;
    label: string;
    fieldName: string;
    className?: string;
    classNames?: string[];
    style?: any;
    disableSort?: boolean,
    rowRatio?: string,
    bodyStyle?: any,
    rederCell?: (data: any) => Element,
}
export interface RowDefinition<T> {
    id: any;
    data: T;
}

export interface AppTableRow {
    id: any,
    data: AppTableCell[]
}

export interface AppTableCell {
    fieldName: string,
    ratio?: string,
    bodyStyle?: {},
    value?: any,
    renderCell?: (data: any) => Element
}

export interface AppTableProp<T> {
    order: Order,
    setOrder: (order: Order) => void,
    orderByFieldName: any,
    setOrderByFieldName: (orderBy: any) => void,
    handleClick: (event: React.MouseEvent<unknown>, id: any) => void,
    columns: ColumnDefinition[],
    rows: Array<T>
}

function CustomTableHead(props: CustomTableHeadProp) {
    const { order, orderBy, onRequestSort } =
        props;
    const createSortHandler =
        (property: any) => (event: React.MouseEvent<unknown>) => {
            onRequestSort(event, property);
        };

    return (
        <TableHead>
            <TableRow>
                {props.columns.map((column) => (
                    <TableCell
                        key={column.id}
                        align="left"
                        padding={column.disablePadding ? 'none' : 'normal'}

                        //modify 
                        sortDirection={orderBy === column.id ? order : false}
                    >
                        <TableSortLabel
                            active={orderBy === column.id}
                            direction={orderBy === column.id ? order : 'asc'}
                            onClick={createSortHandler(column.id)}
                            IconComponent={ArrowDropDown}
                            className={`font-bold ${column.className}`}
                            classes={column.classNames}
                            sx={column.style}
                            disabled={column.disableSort ?? false}
                        >
                            {column.label}
                            {orderBy === column.id ? (
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

function mapToAppTableRows<T>(
    columns: ColumnDefinition[],
    rows: RowDefinition<T>[]
): AppTableRow[] {
    return rows.map((row) => {
        const data: AppTableCell[] = columns.map((column) => {
            const { fieldName } = column;
            return {
                fieldName,
                value: (row.data as Record<string, any>)[fieldName],
                renderCell: column.rederCell,
                ratio: column.rowRatio,
                bodyStyle: column.bodyStyle
            };
        });

        return {
            id: row.id,
            data,
        };
    });
}

export function AppTable<T>(props: AppTableProp<T>) {

    const handleRequestSort = (
        event: React.MouseEvent<unknown>,
        property: any,
    ) => {
        const isAsc = props.orderByFieldName === property && props.order === 'asc';
        props.setOrder(isAsc ? 'desc' : 'asc');
        props.setOrderByFieldName(property);
    };

    const rowData: Array<RowDefinition<T>> = props.rows.map((item, index) => ({
        id: index,
        data: item,
    }))

    const data: AppTableRow[] = mapToAppTableRows<T>(props.columns, rowData);
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
                    <CustomTableHead
                        order={props.order}
                        orderBy={props.orderByFieldName}
                        onRequestSort={handleRequestSort}
                        columns={props.columns}
                    />
                    <TableBody>
                        {data && data.map((row, index) => {

                            return (<>
                                <TableRow
                                    hover
                                    onClick={(event) => props.handleClick(event, row.id)}
                                    // role="checkbox"
                                    // aria-checked={isItemSelected}
                                    tabIndex={-1}
                                    key={row.id}
                                    // selected={isItemSelected}
                                    sx={{ cursor: 'pointer' }}
                                >
                                    {row.data.map((item, index) => {
                                        return (
                                            <TableCell
                                                align="left"
                                                className={item.ratio ?? ""}
                                                key={index}
                                                sx={item.bodyStyle}
                                            >
                                                {item.value ?? item.renderCell ?? ''}
                                            </TableCell>
                                        );
                                    })}
                                </TableRow>
                            </>
                            );
                        })}
                    </TableBody>
                </Table>
            </TableContainer>
        </Box>
    );
}

export default AppTable;