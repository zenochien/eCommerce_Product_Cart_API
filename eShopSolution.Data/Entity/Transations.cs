using eShopSolution.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entity
{
    public class Transations
    {
        public int Id { get; set; }
        public DateTime TranslationDate { get; set; }
        public int ExternalTranslactionId { get; set; }
        public decimal Amount { get; set; }
        public decimal Fee { get; set; }
        public string Result { get; set; }
        public string Message { get; set; }
        public TranslationStatus Status { get; set; }
        public string Provider { get; set; }
        public Guid UserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
