import React from 'react';
import AccountHeader from './AccountHeader';

const Header = () => {
    
    return (
        <div className="bg-primary h-14 flex justify-center text-lg font-semibold">
            <div className="w-[90%] flex justify-between items-center">
                <p className='text-white'>Home</p>
                <AccountHeader userName ="default"/>
            </div>
        </div>
    );
};

export default Header;