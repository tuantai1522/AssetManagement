import { useState } from "react";
import PaginationButton from "../../app/components/paginationButtons/paginationButtons";
import { useForm } from "react-hook-form";
import AppSelectedInput from "../../app/components/AppSelectedInput";
import AppSearchInput from "../../app/components/AppSearchInput";

const arr = [
  {
    id: "1",
    name: "All",
  },
  {
    id: "2",
    name: "Staff",
  },
  {
    id: "3",
    name: "Admin",
  },
];
const Test = () => {
  const [currentPage, setCurrentPage] = useState(1);

  const [currentType, setCurrentType] = useState("All");

  const [currentSearch, setCurrentSearch] = useState("");

  const { control } = useForm({
    mode: "onChange",
  });

  return (
    <>
      <PaginationButton totalPage={50} onChange={setCurrentPage} />

      <AppSelectedInput
        onChange={setCurrentType}
        label="Type"
        items={arr}
        name="Type"
        control={control}
      />

      <AppSearchInput
        name="Search"
        control={control}
        onChange={setCurrentSearch}
      />
    </>
  );
};

export default Test;
