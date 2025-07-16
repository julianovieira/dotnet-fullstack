﻿namespace MoneyFlow.Core.Requests.Transactions;

using MoneyFlow.Core.Enums;
using System.ComponentModel.DataAnnotations;

public class CreateTransactionRequest : Request 
{
    [Required (ErrorMessage = "Titulo inválido.")]
    public string Title { get; set; } = string.Empty;

    [Required (ErrorMessage = "Tipo inválido.")]
    public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

    [Required (ErrorMessage = "Valor inválido.")]
    public decimal Amount { get; set; }

    [Required (ErrorMessage = "Categoria inválida.")]
    public long CategoryId { get; set; }

    [Required (ErrorMessage = "Data inválida.")]
    public DateTime? PaidOrReceivedAt { get; set; }
}
