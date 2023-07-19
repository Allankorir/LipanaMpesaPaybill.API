using LipanaMpesaPaybill.API.Core;
using LipanaMpesaPaybill.API.Core.Services;
using LipanaMpesaPaybill.API.Infrastructure.Data;

namespace LipanaMpesaPaybill.API.Infrastructure.Implementations
{
    public class TransactionService : ITransactionService
    {
        private readonly PaybillDbContext _context;

        public TransactionService(PaybillDbContext context)
        {
            _context = context;
        }
        public async Task<Transaction> PostTransactionAsync(Transaction transaction)
        {
            try
            {
                var payment = await _context.Transactions.AddAsync(transaction);

                await _context.SaveChangesAsync();  

                return transaction;
            }
            catch (Exception)
            {

                throw;
            }
         
        }
    }
}
