import { ArrowDropDown, ArrowDropUp } from "@mui/icons-material";
import {
  Box,
  Chip,
  Stack,
  SxProps,
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
  maxWidth?: string;
}
export interface RowDefinition<T> {
  id: any;
  data: T;
}

export interface AppTableRow {
  id: any;
  data: AppTableCell[];
}

export interface AppTableCell {
  fieldName: string;
  ratio?: string;
  bodyStyle?: React.CSSProperties;
  value?: any;
  renderCell?: JSX.Element;
  minWidth?: string;
  maxWidth?: string;
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
  tableStyle?: SxProps;
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
                  sx={{ ...column.style, minWidth: column.minWidth, maxWidth: column.maxWidth }}
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
): AppTableRow[] {
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
        maxWidth: column.maxWidth,
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

  const data: AppTableRow[] = mapToAppTableRows<T>(props.columns, rowData);
  return (
    <Box sx={{ width: "100%" }}>
      <TableContainer sx={{ width: "100%", mb: 2,
      overflowX: "unset"
       }}>
        <Table
          sx={{
            minWidth: 800,
            borderCollapse: "separate",
            borderSpacing: "20px 0",
            "& td, & th": {
              borderColor: "transparent",
              borderBottom: "1px solid grey",
              paddingLeft: 0,
              paddingRight: 0,
            },
            "& td:last-child, & th:last-child": {
              border: "none",
              display: "flex",
              justifyContent: "end",
              width: "fit-content",
            },

            "& thead tr th": {
              borderBottom: "1px solid black",
              fontWeight: "bold",
            },
            ...props.tableStyle
            
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
            {data &&
              data.length > 0 &&
              data.map((row, index) => {
                return (
                    <TableRow
                      onClick={(event) => {
                        props.handleClick(event, row.id);
                      }}
                      tabIndex={-1}
                      key={index}
                      sx={{ cursor: "pointer" }}
                    >
                      {row.data.map((item, index) => {
                        return (
                          <TableCell
                            align="left"
                            className={item.ratio ?? ""}
                            key={index}
                            sx={{ ...item.bodyStyle, minWidth: item.minWidth, maxWidth: item.maxWidth }}
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
      </TableContainer>
    </Box>
  );
}

export default AppTable;
