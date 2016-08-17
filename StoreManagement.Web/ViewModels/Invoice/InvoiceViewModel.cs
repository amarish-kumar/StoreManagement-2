﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StoreManagement.Web.ViewModels.Invoice
{
    public class InvoiceViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Number { get; set; }

        [Timestamp]
        public byte[] Version { get; set; }

        public Customer.CustomerViewModel Customer { get; set; }   // needs check

        ICollection<InvoiceItem.InvoiceItemViewModel> Items { get; set; }
    }
}