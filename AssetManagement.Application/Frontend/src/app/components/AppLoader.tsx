interface Props {
  width?: number;
  height?: number;
  border?: number;
}
export default function AppLoader({
  width = 10,
  height = 10,
  border = 4,
}: Props) {
  return (
    <div
      className={`animate-spin border-${border} border-primary border-t-white border-b-white rounded-full w-${width} h-${height} `}
    ></div>
  );
}
