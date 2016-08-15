namespace FaciShare.WebService.Feeds.ReceiptService.Models
{
    public class ReceiptModel
    {
        public string Id { get; set; }

        public int EnterpriseId { get; set; }

        public int FeedId { get; set; }

        public int EmployeeId { get; set; }

        public int Status { get; set; }
    }
}