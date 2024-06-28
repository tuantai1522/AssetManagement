import './App.css';
import { Outlet } from 'react-router-dom';
import { NotificationProvider } from './app/components/toast/NotifyContext';

function App() {
  return (
    <NotificationProvider>
      <Outlet/>
    </NotificationProvider>
  );
}

export default App;
