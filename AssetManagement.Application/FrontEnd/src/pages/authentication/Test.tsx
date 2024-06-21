import { useState } from "react";
import PaginationButton from "../../app/components/paginationButtons/paginationButtons";

const Test = () => {
  const [currentPage, setCurrentPage] = useState(1);

  return (
    <>
      <PaginationButton totalPage={50} onChange={setCurrentPage} />
    </>
  );
};

export default Test;
