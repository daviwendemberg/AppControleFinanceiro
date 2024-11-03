using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiro.Models;
using LiteDB;

namespace ControleFinanceiro.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly LiteDatabase _dataBase;
        private readonly string collectionName = "transactions";
        public TransactionRepository()
        {
            _dataBase = new LiteDatabase("Filename=C:/users/AppData/database.db; Connection=Shared");
        }

        public List<Transaction> GetAll()
        {
            return _dataBase.GetCollection<Transaction>(collectionName)
                .Query()
                .OrderByDescending(a=>a.Date)
                .ToList();
        }
        public void Add(Transaction transaction) 
        {
            _dataBase.GetCollection<Transaction>(collectionName)
                .Insert(transaction);
        }
        public void Update(Transaction transaction) 
        {
            _dataBase.GetCollection<Transaction>(collectionName)
                .Update(transaction);
        }
        public void Delete(Transaction transaction) 
        {
            _dataBase.GetCollection<Transaction>(collectionName)
                .Delete(transaction.Id);
        }
    }
}
