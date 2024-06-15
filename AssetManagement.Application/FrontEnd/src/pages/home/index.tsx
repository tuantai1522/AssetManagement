import logo from "../../app/assets/images/logo/logo.svg";
import agent from "../../app/api/agent";
import { Product } from "../../app/models/Product";
export default function HomePage() {
  const {
    data: products,
    isLoading: productsIsLoading,
    mutate: productsMutate,
  } = agent.Product.all();

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p className="text-blue-600">This is a homepage</p>
        <a
          className="text-red-600"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          This is a homepage
        </a>
      </header>
      {/* Test fetch api */}
      {productsIsLoading ? (
        <div>Loading...</div>
      ) : (
        <div>
          <p className="text-red-600 font-bold text-lg mt-2">
            This is for test fetch api
          </p>
          <table className="table-auto">
            <thead>
              <tr>
                <th>ID</th>
                <th>Title</th>
                <th>Price</th>
                <th>Category</th>
              </tr>
            </thead>
            <tbody>
              {products?.map((product: Product) => (
                <tr key={product.id}>
                  <td>{product.id}</td>
                  <td>{product.title}</td>
                  <td>{product.price}</td>
                  <td>{product.category}</td>
                </tr>
              ))}
            </tbody>
          </table>
          <button onClick={() => productsMutate()}>Refetch</button>
        </div>
      )}
    </div>
  );
}
