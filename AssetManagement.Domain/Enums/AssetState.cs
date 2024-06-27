namespace AssetManagement.Domain.Enums
{
    public enum AssetState
    {
        Available = 1,
        NotAvailable = 2,
        WaitingForRecycling = 3,
        Recycled = 4,
        Assigned = 5
    }
}
