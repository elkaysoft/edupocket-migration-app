﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum TransactionType
    {
        [Display(Name = "Wallet Inflow")]
        WalletInflow,
        [Display(Name = "Local Transfer")]
        LocalTransfer,
        [Display(Name = "Outbound Transfer")]
        OutboundTransfer
    }
}
