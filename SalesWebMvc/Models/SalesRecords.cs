using SalesWebMvc.Models.Enums;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SalesWebMvc.Models
{
    public class SalesRecords
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SalesRecords()
        {

        }

        public SalesRecords(int id, DateTime date, double amount, SalesStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
