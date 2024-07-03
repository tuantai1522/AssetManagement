import { ArrowDropDown, ArrowDropUp } from "@mui/icons-material";
import {
  Box,
  Chip,
  Stack,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  TableSortLabel,
  Typography,
} from "@mui/material";
import { visuallyHidden } from "@mui/utils";
import AppLoader from "../AppLoader";

export interface CustomTableHeadProp {
  onRequestSort: (event: React.MouseEvent<unknown>, property: any) => void;
  order?: Order;
  orderBy?: any;
  columns: ColumnDefinition[];
}
export type Order = "asc" | "desc";
export interface ColumnDefinition {
  disablePadding?: boolean;
  id?: any;
  label: string;
  fieldName: string;
  className?: string;
  classNames?: string[];
  style?: React.CSSProperties;
  disableSort?: boolean;
  rowRatio?: string;
  bodyStyle?: React.CSSProperties;
  renderCell?: (data: any) => JSX.Element;
  minWidth?: string;
}
export interface RowDefinition<T> {
  id: any;
  data: T;
}

export interface AppTableRow<T> {
  id: any;
  rows: AppTableCell[];
  data?: T;
}

export interface AppTableCell {
  fieldName: string;
  ratio?: string;
  bodyStyle?: React.CSSProperties;
  value?: any;
  renderCell?: JSX.Element;
  minWidth?: string;
}

export interface AppTableProp<T> {
  order?: Order;
  setOrder: (order: Order) => void;
  orderByFieldName?: any;
  setOrderByFieldName: (orderBy: any) => void;
  handleClick: (event: React.MouseEvent<unknown>, id: any) => void;
  columns: ColumnDefinition[];
  rows: Array<T>;
  isLoading?: boolean;
}

function CustomTableHead(props: CustomTableHeadProp) {
  let { order, orderBy, onRequestSort } = props;
  order = order ?? "asc";
  const createSortHandler =
    (property: any) => (event: React.MouseEvent<unknown>) => {
      onRequestSort(event, property);
    };

  return (
    <TableHead>
      <TableRow>
        {props.columns &&
          props.columns?.map((column, index) => {
            let key = column.id ?? column.fieldName;
            return (
              <TableCell
                key={index}
                align="left"
                padding={column.disablePadding ? "none" : "normal"}
                //modify
                sortDirection={orderBy === key ? order : false}
              >
                <TableSortLabel
                  active={orderBy === key}
                  direction={orderBy === key ? order : "asc"}
                  onClick={createSortHandler(key)}
                  IconComponent={ArrowDropUp}
                  className={`font-bold ${column.className} ${column.rowRatio}`}
                  classes={column.classNames}
                  sx={{ ...column.style, minWidth: column.minWidth }}
                  disabled={column.disableSort ?? false}
                >
                  {column.label}
                  {orderBy === key ? (
                    <Box component="span" sx={visuallyHidden}>
                      {order === "desc"
                        ? "sorted descending"
                        : "sorted ascending"}
                    </Box>
                  ) : null}
                </TableSortLabel>
              </TableCell>
            );
          })}
      </TableRow>
    </TableHead>
  );
}

function mapToAppTableRows<T>(
  columns: ColumnDefinition[],
  rows: RowDefinition<T>[]
): AppTableRow<RowDefinition<T>>[] {
  return rows?.map((row) => {
    const data: AppTableCell[] = columns.map((column) => {
      const { fieldName } = column;
      const data = (row.data as Record<string, any>)[fieldName];
      return {
        fieldName,
        value: data,
        renderCell: column.renderCell ? column.renderCell(data) : undefined,
        ratio: column.rowRatio,
        bodyStyle: column.bodyStyle,
        minWidth: column.minWidth,
      };
    });

    return {
      id: row.id,
      rows: data,
      data: row
    };
  });
}

export function AssetAssignmentTable<T>(props: AppTableProp<T>) {
  const handleRequestSort = (
    event: React.MouseEvent<unknown>,
    property: any
  ) => {
    const isAsc = props.orderByFieldName === property && props.order === "asc";
    props.setOrder(isAsc ? "desc" : "asc");
    props.setOrderByFieldName(property);
  };

  const rowData: Array<RowDefinition<T>> = props.rows?.map((item, index) => ({
    id: index,
    data: item,
  }));

  const data: AppTableRow<RowDefinition<T>>[] = mapToAppTableRows<T>(props.columns, rowData);
  return (
    <Box sx={{ }}>
      <div 
       >
        <Table
          sx={{
            width: '100%',
            marginLeft: '-20px',
            borderCollapse: "separate",
            borderSpacing: "20px 0px",
            "& td, & th": {
              borderColor: "transparent",
              borderBottom: "1px solid grey",
              paddingLeft: 0,
              paddingRight: 0,
            },
            "& td:first-child, & th:first-child": {
              border: "none",
            },

            "& thead tr th": {
              borderBottom: "1px solid black",
              fontWeight: "bold",
            },
            
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
          <TableBody
            sx={{
              width: '100%'
            }}
          >
            {data &&
              data.length > 0 &&
              data.map((row, index) => {
                return (
                    <TableRow
                      tabIndex={-1}
                      key={index}
                      sx={{ cursor: "pointer" }}
                      onClick={(event) => {
                        props.handleClick(event, row.data);
                      }}
                    >
                      {row.rows.map((item, index) => {
                        return (
                          <TableCell
                            align="left"
                            className={item.ratio ?? ""}
                            key={index}
                            sx={{ ...item.bodyStyle, minWidth: item.minWidth }}
                            
                          >
                            {item.renderCell ?? item.value ?? ""}
                          </TableCell>
                        );
                      })}
                    </TableRow>
                );
              })}
          </TableBody>
        </Table>
        {props.isLoading === false && (!data || data.length === 0) && (
          <div className="min-h-48 flex justify-center items-center">
            <Typography variant="h4" gutterBottom color={"#CF2338"}>
              No data found
            </Typography>
          </div>
        )}
        {props.isLoading === true && (
          <div className="min-h-48 flex justify-center items-center">
            <AppLoader />
          </div>
        )}
      </div>
    </Box>
  );
}

export default AssetAssignmentTable;
