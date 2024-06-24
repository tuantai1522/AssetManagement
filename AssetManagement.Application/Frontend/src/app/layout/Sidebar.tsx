import SidebarItem from './SidebarItem';

const Sidebar = () => {
    return (
        <div className="w-fit bg-white h-fit mt-10">
            <div className='logo'>
                <div className="logo-image w-[6rem]">
                    <img src="https://i0.wp.com/blog.nashtechglobal.com/wp-content/uploads/2023/04/nashTechLogo-red-.png?fit=320%2C320&ssl=1" alt="NashTech-logo" className='w-full h-full object-cover'></img>
                </div>
                <p className="text-primary text-xl font-bold">Online Asset Management</p>
            </div>
            <div className='menu mt-8 flex flex-col gap-1'>
                <SidebarItem url="/" name="Home"/>
                <SidebarItem url ="/user-manage" name="Manage User"/>
                <SidebarItem url ="/asset-manage" name="Manage Asset" />
                <SidebarItem url ="/assignment-manage" name="Manage Assignment" />
                <SidebarItem url ="/request-returning" name="Request for Returning" />
                <SidebarItem url ="/report" name="Report" />
            </div>
        </div>
    );
};

export default Sidebar;