namespace MoneyFlow.Core.Request.Transactions;

public class GetTransactionByPeriodRequest : Request
{
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}