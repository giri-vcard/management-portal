using System;
using System.ComponentModel.DataAnnotations;

namespace ManagementPortal.Models
{
    public class AccountSubscription
    {
        [Key]
        public Guid account_subscription_id { get; set; }
        public Guid account_id { get; set; }
        public int subscription_status { get; set; }
        public int subscription_type { get; set; }
        public string subscription_currency { get; set; }
        public decimal subscription_amount { get; set; }
        public DateTime date_created { get; set; }
        public string created_by { get; set; }
        public DateTime date_modified { get; set; }
        public string modified_by { get; set; }
        public DateTime date_renewed { get; set; }
        public DateTime? date_paid { get; set; }
    }
}