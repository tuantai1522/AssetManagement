// NotificationContext.tsx
import React, { createContext, useContext, useState, useEffect, ReactNode } from 'react';
import Toast from '.';
import eventEmitter from '../../hooks/EventMitter';


interface NotificationContextType {
  addNotification: (message: string, severity: "error" | "info" | "success" | "warning") => void;
}

const NotificationContext = createContext<NotificationContextType | undefined>(undefined);

export const NotificationProvider: React.FC<{ children: ReactNode }> = ({ children }) => {
  const [isOpen, setIsOpen] = useState(false);
  const [message, setMessage] = useState('');
  const [severity, setSeverity] = useState<"error" | "info" | "success" | "warning">("info");

  const addNotification = (msg: string, sev: "error" | "info" | "success" | "warning") => {
    setMessage(msg);
    setSeverity(sev);
    setIsOpen(true);
  };

  const handleClose = () => {
    setIsOpen(false);
  };

  useEffect(() => {
    eventEmitter.on('notification', addNotification);

    return () => {
      eventEmitter.off('notification', addNotification);
    };
  }, []);

  return (
    <NotificationContext.Provider value={{ addNotification }}>
      {children}
      <Toast
        verticalPosition="top"
        horizontalPosition="right"
        isOpen={isOpen}
        duration={6000}
        onClose={handleClose}
        severity={severity}
        message={message}
      />
    </NotificationContext.Provider>
  );
};

export const useNotification = () => {
  const context = useContext(NotificationContext);
  if (!context) {
    throw new Error('useNotification must be used within a NotificationProvider');
  }
  return context;
};
