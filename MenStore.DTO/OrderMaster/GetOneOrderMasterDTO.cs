namespace MenStore.DTO.OrderMaster
{
    //public record GetOneOrderMasterDTO(int Id, double Total, int ClientId, string ClientName, DateTime OrderDateTime, int OrderState);
    public class GetOneOrderMasterDTO
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public DateTime OrderDateTime { get; set; }
        public int OrderState { get; set; }
    }
}
