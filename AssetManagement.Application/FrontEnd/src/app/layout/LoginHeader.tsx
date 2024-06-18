import React, { Component } from 'react';

class LoginHeader extends Component {
    render() {
        return (
            <div className="bg-primary h-14 flex justify-center text-lg font-semibold">
                <div className="w-[90%] flex items-center">
                    <div className="logo w-10 h-10 bg-white border-2 border-white mr-4">
                        <img src="https://i0.wp.com/blog.nashtechglobal.com/wp-content/uploads/2023/04/nashTechLogo-red-.png?fit=320%2C320&ssl=1" alt="" className="w-full h-full object-cover"></img>
                    </div>
                    <p className='text-white'>Online Asset Management</p>
                </div>
            </div>
        );
    }
}

export default LoginHeader;