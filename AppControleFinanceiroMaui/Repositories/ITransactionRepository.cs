using AppControleFinanceiroMaui.Models;

namespace AppControleFinanceiroMaui.Repositories
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        void Delete(Transaction transaction);
        List<Transaction> GetAll();
        void Update(Transaction transaction);
    }
}