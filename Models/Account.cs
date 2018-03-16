using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ManagementPortal.Models
{
    public class Account
    {
        public Account()
        {
            account_subscription = new HashSet<AccountSubscription>();
        }
        [Key]
        public Guid account_id { get; set; }
        public int account_status { get; set; }
        public DateTime date_created { get; set; }
        public DateTime date_modified { get; set; }
        public string vcard_id { get; set; }
        public string account_password { get; set; }
        public string phone_country { get; set; }
        public string phone_number { get; set; }
        public string email_address { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool password_change { get; set; }
        public string middle_name { get; set; }
        
        public ICollection<AccountSubscription> account_subscription { get; set; }
    }
}