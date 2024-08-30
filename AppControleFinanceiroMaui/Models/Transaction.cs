using AppControleFinanceiroMaui.Models.Enums;
using LiteDB;

namespace AppControleFinanceiroMaui.Models
{
    public class Transaction
    {
        [BsonId]
        public int Id { get; set; }
        public ETransactionType Type { get; set; }
        public String Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public double Value { get; set; }
    }
}
