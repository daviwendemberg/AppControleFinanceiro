﻿using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Models
{
    public class Transaction
    {
        [BsonId]
        public int Id { get; set; }
        public TransactionType Type { get; set; }
        public string Name { get; set; }
        public DateTimeOffset Date { get; set; }
        public decimal Value { get; set; }
    }

    public enum TransactionType
    {
        Income, 
        Expenses
    }
}
