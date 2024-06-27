export interface Asset {
    id: string,
    assetCode: string,
    name: string,
    categoryName: string, 
    specification: string,
    installedDate: Date,
    state: string,
    location: string,
    createdAt: Date,
    lastUpdated: Date
}