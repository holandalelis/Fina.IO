
namespace Fina.Core.Requests.Transactions
{
    public class GetTransactionsByPeriod : PagedRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}