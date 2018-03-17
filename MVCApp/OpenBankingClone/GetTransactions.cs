using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCApp.Models;

namespace MVCApp.OpenBankingClone
{
    public static class GetTransactions
    {
        public static List<Transactions> RetreiveTransactions()
        {
            //Transactions for April 2017
            //Credit
            Transactions transaction = new Transactions()
            {
                AccountId = "22289",
                TransactionId = "123",
                TransactionReference = "Ref 123",
                Amount = new Amounts()
                {
                    Amount = "800.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Credit,
                Status = "Booked",
                BookingDateTime = "date",
                ValueDateTime = "2017-04-01T10:45:22+00:00",
                TransactionInformation = "Salary for the Month March 2017",
                BankCodes = new BankTransactionCode()
                {
                     Code    = "ReceivedCreditTransfer",
                     SubCode = "DomesticCreditTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "Transfer",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "800.00",
                        Currency = "GBP",                   
                    },
                    CreditDebitIndicator = TransactionType.Credit,
                    Type = "InterimBooked"
                }
            };
            //Debit
            Transactions transaction2 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "567",
                TransactionReference = "Ref 124",
                Amount = new Amounts()
                {
                    Amount = "70.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-04-02T14:22:09+00:00",
                ValueDateTime = "2017-04-02T14:22:09+00:00",
                TransactionInformation = "Paid the gas bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "730.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction3 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "567",
                TransactionReference = "Ref 567",
                Amount = new Amounts()
                {
                    Amount = "30.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-04-12T14:22:09+00:00",
                ValueDateTime = "2017-04-12T14:22:09+00:00",
                TransactionInformation = "Paid the Mobile bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "700.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction4 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "568",
                TransactionReference = "Ref 568",
                Amount = new Amounts()
                {
                    Amount = "70.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-04-06T14:22:09+00:00",
                ValueDateTime = "2017-04-06T14:22:09+00:00",
                TransactionInformation = "Entertainment",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "630.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction5 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "569",
                TransactionReference = "Ref 569",
                Amount = new Amounts()
                {
                    Amount = "60.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-04-16T14:22:09+00:00",
                ValueDateTime = "2017-04-16T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "570.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction6 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "570",
                TransactionReference = "Ref 570",
                Amount = new Amounts()
                {
                    Amount = "100.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-04-25T14:22:09+00:00",
                ValueDateTime = "2017-04-25T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "470.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };

            //Transactions for May 2017 
            //Credit
            Transactions transaction7 = new Transactions()
            {
                AccountId = "22289",
                TransactionId = "571",
                TransactionReference = "Ref 571",
                Amount = new Amounts()
                {
                    Amount = "800.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Credit,
                Status = "Booked",
                BookingDateTime = "2017-05-01T10:45:22+00:00",
                ValueDateTime = "2017-05-01T10:45:22+00:00",
                TransactionInformation = "Salary for the Month April 2017",
                BankCodes = new BankTransactionCode()
                {
                    Code = "ReceivedCreditTransfer",
                    SubCode = "DomesticCreditTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "Transfer",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1270.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Credit,
                    Type = "InterimBooked"
                }
            };
            //Debit
            Transactions transaction8 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "572",
                TransactionReference = "Ref 572",
                Amount = new Amounts()
                {
                    Amount = "60.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-05-02T14:22:09+00:00",
                ValueDateTime = "2017-05-02T14:22:09+00:00",
                TransactionInformation = "Paid the gas bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1210.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction9 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "573",
                TransactionReference = "Ref 573",
                Amount = new Amounts()
                {
                    Amount = "30.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-05-10T14:22:09+00:00",
                ValueDateTime = "2017-05-10T14:22:09+00:00",
                TransactionInformation = "Paid the Mobile bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1180.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction10 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "574",
                TransactionReference = "Ref 574",
                Amount = new Amounts()
                {
                    Amount = "100.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-05-18T14:22:09+00:00",
                ValueDateTime = "2017-05-18T14:22:09+00:00",
                TransactionInformation = "Entertainment",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1080.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction11 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "575",
                TransactionReference = "Ref 575",
                Amount = new Amounts()
                {
                    Amount = "70.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-05-26T14:22:09+00:00",
                ValueDateTime = "2017-05-26T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1010.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };


            //Transactions for June 2017 
            //Credit
            Transactions transaction12 = new Transactions()
            {
                AccountId = "22289",
                TransactionId = "576",
                TransactionReference = "Ref 576",
                Amount = new Amounts()
                {
                    Amount = "800.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Credit,
                Status = "Booked",
                BookingDateTime = "2017-06-01T10:47:22+00:00",
                ValueDateTime = "2017-06-01T10:47:22+00:00",
                TransactionInformation = "Salary for the Month May 2017",
                BankCodes = new BankTransactionCode()
                {
                    Code = "ReceivedCreditTransfer",
                    SubCode = "DomesticCreditTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "Transfer",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1810.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Credit,
                    Type = "InterimBooked"
                }
            };
            //Debit
            Transactions transaction13 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "577",
                TransactionReference = "Ref 577",
                Amount = new Amounts()
                {
                    Amount = "70.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-05-02T14:22:09+00:00",
                ValueDateTime = "2017-05-02T14:22:09+00:00",
                TransactionInformation = "Paid the gas bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1740.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction14 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "573",
                TransactionReference = "Ref 573",
                Amount = new Amounts()
                {
                    Amount = "30.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-05-10T14:22:09+00:00",
                ValueDateTime = "2017-05-10T14:22:09+00:00",
                TransactionInformation = "Paid the Mobile bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1180.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction15 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "578",
                TransactionReference = "Ref 578",
                Amount = new Amounts()
                {
                    Amount = "80.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-06-20T14:22:09+00:00",
                ValueDateTime = "2017-06-18T14:22:09+00:00",
                TransactionInformation = "Entertainment",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1660.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction16 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "579",
                TransactionReference = "Ref 579",
                Amount = new Amounts()
                {
                    Amount = "80.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-06-27T14:22:09+00:00",
                ValueDateTime = "2017-06-26T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "1580.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
        
            //Transactions for July 2017 
            //Credit
            Transactions transaction17 = new Transactions()
            {
                AccountId = "22289",
                TransactionId = "580",
                TransactionReference = "Ref 580",
                Amount = new Amounts()
                {
                    Amount = "800.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Credit,
                Status = "Booked",
                BookingDateTime = "2017-07-01T10:45:22+00:00",
                ValueDateTime = "2017-07-01T10:45:22+00:00",
                TransactionInformation = "Salary for the Month June 2017",
                BankCodes = new BankTransactionCode()
                {
                    Code = "ReceivedCreditTransfer",
                    SubCode = "DomesticCreditTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "Transfer",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2380.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Credit,
                    Type = "InterimBooked"
                }
            };
            //Debit
            Transactions transaction18 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "581",
                TransactionReference = "Ref 581",
                Amount = new Amounts()
                {
                    Amount = "50.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-07-02T14:22:09+00:00",
                ValueDateTime = "2017-07-02T14:22:09+00:00",
                TransactionInformation = "Paid the gas bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2330.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction19 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "582",
                TransactionReference = "Ref 582",
                Amount = new Amounts()
                {
                    Amount = "30.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-07-14T14:22:09+00:00",
                ValueDateTime = "2017-07-14T14:22:09+00:00",
                TransactionInformation = "Paid the Mobile bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2300.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction20 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "583",
                TransactionReference = "Ref 583",
                Amount = new Amounts()
                {
                    Amount = "100.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-07-20T14:22:09+00:00",
                ValueDateTime = "2017-07-20T14:22:09+00:00",
                TransactionInformation = "Entertainment",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2200.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction21 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "584",
                TransactionReference = "Ref 584",
                Amount = new Amounts()
                {
                    Amount = "80.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-07-26T14:22:09+00:00",
                ValueDateTime = "2017-07-26T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2120.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };

            //Transactions for August 2017 
            //Credit
            Transactions transaction22 = new Transactions()
            {
                AccountId = "22289",
                TransactionId = "585",
                TransactionReference = "Ref 585",
                Amount = new Amounts()
                {
                    Amount = "800.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Credit,
                Status = "Booked",
                BookingDateTime = "2017-08-01T10:48:22+00:00",
                ValueDateTime = "2017-08-01T10:48:22+00:00",
                TransactionInformation = "Salary for the Month July 2017",
                BankCodes = new BankTransactionCode()
                {
                    Code = "ReceivedCreditTransfer",
                    SubCode = "DomesticCreditTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "Transfer",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2920.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Credit,
                    Type = "InterimBooked"
                }
            };
            //Debit
            Transactions transaction23 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "586",
                TransactionReference = "Ref 586",
                Amount = new Amounts()
                {
                    Amount = "60.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-08-02T14:22:09+00:00",
                ValueDateTime = "2017-08-02T14:22:09+00:00",
                TransactionInformation = "Paid the gas bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2860.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction24 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "587",
                TransactionReference = "Ref 587",
                Amount = new Amounts()
                {
                    Amount = "50.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-08-15T14:22:09+00:00",
                ValueDateTime = "2017-08-15T14:22:09+00:00",
                TransactionInformation = "Paid the Mobile bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2810.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction25 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "588",
                TransactionReference = "Ref 588",
                Amount = new Amounts()
                {
                    Amount = "120.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-08-18T14:22:09+00:00",
                ValueDateTime = "2017-08-18T14:22:09+00:00",
                TransactionInformation = "Entertainment",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2690.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction26 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "589",
                TransactionReference = "Ref 589",
                Amount = new Amounts()
                {
                    Amount = "90.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-08-27T14:22:09+00:00",
                ValueDateTime = "2017-08-27T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "2620.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };

            //Transactions for September 2017 
            //Credit
            Transactions transaction27 = new Transactions()
            {
                AccountId = "22289",
                TransactionId = "590",
                TransactionReference = "Ref 590",
                Amount = new Amounts()
                {
                    Amount = "800.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Credit,
                Status = "Booked",
                BookingDateTime = "2017-09-01T10:48:22+00:00",
                ValueDateTime = "2017-09-01T10:48:22+00:00",
                TransactionInformation = "Salary for the Month August 2017",
                BankCodes = new BankTransactionCode()
                {
                    Code = "ReceivedCreditTransfer",
                    SubCode = "DomesticCreditTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "Transfer",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "3420.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Credit,
                    Type = "InterimBooked"
                }
            };
            //Debit
            Transactions transaction28 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "591",
                TransactionReference = "Ref 591",
                Amount = new Amounts()
                {
                    Amount = "70.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-09-02T14:22:09+00:00",
                ValueDateTime = "2017-09-02T14:22:09+00:00",
                TransactionInformation = "Paid the gas bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "3350.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction29 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "592",
                TransactionReference = "Ref 592",
                Amount = new Amounts()
                {
                    Amount = "60.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-09-15T14:22:09+00:00",
                ValueDateTime = "2017-09-15T14:22:09+00:00",
                TransactionInformation = "Paid the Mobile bill",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "3290.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction30 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "593",
                TransactionReference = "Ref 593",
                Amount = new Amounts()
                {
                    Amount = "40.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-09-18T14:22:09+00:00",
                ValueDateTime = "2017-09-18T14:22:09+00:00",
                TransactionInformation = "Entertainment",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "3250.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };
            Transactions transaction31 = new Transactions()
            {
                AccountId = "31820",
                TransactionId = "594",
                TransactionReference = "Ref 594",
                Amount = new Amounts()
                {
                    Amount = "70.00",
                    Currency = "GBP"
                },
                CreditDebitIndicator = TransactionType.Debit,
                Status = "Booked",
                BookingDateTime = "2017-09-29T14:22:09+00:00",
                ValueDateTime = "2017-09-29T14:22:09+00:00",
                TransactionInformation = "Shopping",
                BankCodes = new BankTransactionCode()
                {
                    Code = "IssuedCreditTransfer",
                    SubCode = "AutomaticTransfer"
                },

                ProprietaryBank = new ProprietaryBankTransactionCode()
                {
                    Code = "DirectDebit",
                    Issuer = "AlphaBank"
                },

                balance = new Balance()
                {
                    BalanceAmount = new Amounts()
                    {
                        Amount = "3180.00",
                        Currency = "GBP",
                    },
                    CreditDebitIndicator = TransactionType.Debit,
                    Type = "InterimBooked"
                }
            };


            var TransactionList = new List<Transactions>();
            TransactionList.Add(transaction);
            TransactionList.Add(transaction2);
            TransactionList.Add(transaction3);
            TransactionList.Add(transaction4);
            TransactionList.Add(transaction5);
            TransactionList.Add(transaction6);
            TransactionList.Add(transaction7);
            TransactionList.Add(transaction8);
            TransactionList.Add(transaction9);
            TransactionList.Add(transaction10);
            TransactionList.Add(transaction11);
            TransactionList.Add(transaction12);
            TransactionList.Add(transaction13);
            TransactionList.Add(transaction14);
            TransactionList.Add(transaction15);
            TransactionList.Add(transaction16);
            TransactionList.Add(transaction17);
            TransactionList.Add(transaction18);
            TransactionList.Add(transaction19);
            TransactionList.Add(transaction20);
            TransactionList.Add(transaction21);
            TransactionList.Add(transaction22);
            TransactionList.Add(transaction23);
            TransactionList.Add(transaction24);
            TransactionList.Add(transaction25);
            TransactionList.Add(transaction26);
            TransactionList.Add(transaction27);
            TransactionList.Add(transaction28);
            TransactionList.Add(transaction29);
            TransactionList.Add(transaction30);
            TransactionList.Add(transaction31);
            return TransactionList;
        }
    }
}