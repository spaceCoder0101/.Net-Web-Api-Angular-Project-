﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentApi.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column(TypeName ="nvarchar(16)")]
        public string CardOwner { get; set; }
        [Column(TypeName = "nvarchar(5)")]
        public string ExpirationDate { get; set; }
        [Column(TypeName = "nvarchar(3)")]

        public string SecurityCode { get; set; }
    }
}
