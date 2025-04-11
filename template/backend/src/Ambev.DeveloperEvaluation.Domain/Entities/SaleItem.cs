﻿using System;

namespace Ambev.DeveloperEvaluation.Domain.Entities
{
    public class SaleItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid SaleId { get; set; }
        public Sale Sale { get; set; }

        public Guid ProductId { get; set; }
        public string ProductDescription { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal DiscountPercentage { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal FinalPrice { get; set; }

        public bool IsCancelled { get; set; }
    }
}