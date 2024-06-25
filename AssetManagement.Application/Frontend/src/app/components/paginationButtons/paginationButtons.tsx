import { useCallback, useState } from "react";
import usePagination, { UsePaginationProps } from "@mui/material/usePagination";
import { styled } from "@mui/material/styles";
import AppPaginatedButton from "../buttons/PaginatedButton";
import { Stack } from "@mui/material";

const List = styled("ul")({
  listStyle: "none",
  padding: 0,
  margin: 0,
  display: "flex",
  gap: 4,
});

interface Props {
  totalPage: number;
  currentPage: number;
  onChange: (page: number) => void;
}

export default function AppPagination({ totalPage, onChange, currentPage = 1 }: Props) {
  const { items } = usePagination({
    count: totalPage,
    page: currentPage
  });

  const key = `${totalPage}-${currentPage}`;

  const handleClick = (page: number) => {
    onChange(page);
  };

  return (
    <List key={key}>
      {items.map(({ page, type, selected, ...item }, index) => {
        let children = null;

        if (type === "start-ellipsis" || type === "end-ellipsis") {
          children = (
            <Stack
              direction="row"
              justifyContent="center"
              alignItems="center"
              spacing={2}
              className="text-primary"
            >
              ...
            </Stack>
          );
        } else if (type === "page") {
          children = (
            <AppPaginatedButton
              content={String(page)}
              styleType={selected ? "primary" : "secondary"}
              {...item}
              onClickOn={(e) => {
                handleClick(page!); // Call handleClick to handle your custom logic
                item.onClick(e);
              }}
              className={`${currentPage === page
                  ? "bg-primary hover:bg-red-600 "
                  : ""
                }`}
            />
          );
        } else if (type === "previous") {
          children = (
            <AppPaginatedButton
              content="Previous"
              styleType="secondary"
              onClickOn={(e) => {
                if (currentPage <= 1) return;
                handleClick(page!);
                item.onClick(e);
              }}
              className={
                currentPage <= 1 ? "opacity-50 cursor-not-allowed" : ""
              }
            />
          );
        } else if (type === "next") {
          children = (
            <AppPaginatedButton
              content="Next"
              styleType="secondary"
              onClickOn={(e) => {
                if (currentPage >= totalPage) return;

                handleClick(page!);
                item.onClick(e);
              }}
              className={
                currentPage >= totalPage ? "opacity-50 cursor-not-allowed" : ""
              }
            />
          );
        }

        return <li key={index}>{children}</li>;
      })}
    </List>
  );
}
