namespace MenStore.DTO.OrderMaster
{
    public record GetOneOrderMasterDTO(int Id, double Total, int ClientId, string ClientName, DateTime OrderDateTime, string OrderState);
}
