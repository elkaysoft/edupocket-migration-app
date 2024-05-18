using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum TransactionType
    {
        [Display(Name = "Fund Wallet")]
        FundWallet,
        [Display(Name = "Wallet to Wallet")]
        Wallet2Wallet,
        [Display(Name = "Wallet to Bank")]
        Wallet2Bank
    }
}
