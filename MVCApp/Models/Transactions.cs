using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Transactions
    {
        public string AccountId { get; set; }

        public string TransactionId { get; set; }

        public string TransactionReference { get; set; }

        public Amounts Amount { get; set; }

        public TransactionType CreditDebitIndicator { get; set; }

        public string Status { get; set; }

        public string BookingDateTime { get; set; }

        public string ValueDateTime { get; set; }

        public string TransactionInformation { get; set; }

        public string AddressLine { get; set; }

        public BankTransactionCode BankCodes { get; set; }

        public ProprietaryBankTransactionCode ProprietaryBank { get; set; }

        public Balance balance { get; set; }

        public string Type { get; set; }

    }

    public class Balance
    {
        public Amounts BalanceAmount { get; set; }

        public string Type { get; set; }

        public TransactionType CreditDebitIndicator { get; set; }
    }

    public class ProprietaryBankTransactionCode
    {
        public string Code { get; set; }

        public string Issuer { get; set; }
    }

    public class BankTransactionCode
    {
        public string Code { get; set; }

        public string SubCode { get; set; }
    }

    public class Amounts
    {
        public string Amount { get; set; }

        public string Currency { get; set; }
    }

    public enum TransactionType
    {
        Credit = 0,
        Debit  = 1
    }
}