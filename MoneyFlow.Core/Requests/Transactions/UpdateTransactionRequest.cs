namespace MoneyFlow.Core.Requests.Transactions;
using MoneyFlow.Core.Enums;
using System.ComponentModel.DataAnnotations;

public class UpdateTransactionRequest : Request
{
    
    public long Id { get; set; }

    [Required (ErrorMessage = "Title inv�lido.")]
    public string Title { get; set; }

    [Required (ErrorMessage = "Descri��o inv�lida.")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required (ErrorMessage = "Categoria inv�lida.")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria inv�lida.")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data inv�lida.")]
    public DateTime? PaidOrReceivedAt { get; set; }
}