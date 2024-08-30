using AppControleFinanceiroMaui.Models;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppControleFinanceiroMaui.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase _database;
        private readonly string collectionName = "transactions";
        public TransactionRepository(LiteDatabase database)
        {
            _database = database;
        }
        public List<Transaction> GetAll()
        {
            return _database.GetCollection<Transaction>(collectionName)
                .Query()
                .OrderByDescending(x => x.Date)
                .ToList();
        }
        public void Add(Transaction transaction)
        {
            _database.GetCollection<Transaction>(collectionName).Insert(transaction);
            _database.GetCollection<Transaction>(collectionName).EnsureIndex(x=>x.Date);
        }
        public void Update(Transaction transaction)
        {

            _database.GetCollection<Transaction>(collectionName).Update(transaction);
        }
        public void Delete(Transaction transaction)
        {

            _database.GetCollection<Transaction>(collectionName).Delete(transaction.Id);
        }
    }
}
