using System.ComponentModel.DataAnnotations;
using Fina.Core.Enums;

namespace Fina.Core.Requests.Transactions
{
    public class UpdateTransactionRequest : Request
    {
        public long Id { get; set; }

        [Required(ErrorMessage = "Título Inválido")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Tipo Inválido")]
        public ETransactionType Type { get; set; } = ETransactionType.Withdraw;

        [Required(ErrorMessage = "Valor Inválida")]
        public decimal Amount { get; set; }

        [Required(ErrorMessage = "Categoria Inválida")]
        public long CategoryId { get; set; }

        [Required(ErrorMessage = "Data Inválida")]
        public DateTime? PaidOrReceivedAt { get; set; }
    }
}