namespace MoneyFlow.Core.Requests.Transactions;
using MoneyFlow.Core.Enums;
using System.ComponentModel.DataAnnotations;

public class UpdateTransactionRequest : Request
{
    
    public long Id { get; set; }

    [Required (ErrorMessage = "Title inválido.")]
    public string Title { get; set; }

    [Required (ErrorMessage = "Descrição inválida.")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required (ErrorMessage = "Categoria inválida.")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage = "Categoria inválida.")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage = "Data inválida.")]
    public DateTime? PaidOrReceivedAt { get; set; }
}