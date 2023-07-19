namespace LipanaMpesaPaybill.API.Core.Services
{
    public interface ITransactionService
    {
        Task<Transaction> PostTransactionAsync(Transaction transaction);
    }
}
