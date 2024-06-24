using POC_Observer.Contract;
using POC_Observer.ReceivableUnit;

ContractService contractService = new();
ReceivableUnit receivableUnit = new();

contractService.Subscribe(receivableUnit);

var contractMessage = new ContractMessage()
{
    Debtor = "Pagarme",
    Document = "123456789",
    Receivables = new List<Receivable>()
    {
        new()
        {
            DueDate = DateTime.Today.AddDays(30),
            PaymentScheme = "VCC",
            ReferenceDate = DateTime.Today,
            SettlementObligations = new List<SettlementObligation>()
            {
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 20
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 200
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 4020
                },
                new()
                {
                    CommitedAmount = 1220,
                    ContractType = "Warranty",
                    ObligationType = "Commited",
                    UncommitedAmount = 0
                }
            }
        },
        new()
        {
            DueDate = DateTime.Today.AddDays(20),
            PaymentScheme = "VCC",
            ReferenceDate = DateTime.Today,
            SettlementObligations = new List<SettlementObligation>()
            {
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 340
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 32405
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 403220
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 120
                }
            }
        },
        new()
        {
            DueDate = DateTime.Today.AddDays(20),
            PaymentScheme = "VCC",
            ReferenceDate = DateTime.Today,
            SettlementObligations = new List<SettlementObligation>()
            {
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 334
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 305
                },
                new()
                {
                    CommitedAmount = 0,
                    ContractType = "Warranty",
                    ObligationType = "Free",
                    UncommitedAmount = 420
                },
                new()
                {
                    CommitedAmount = 123210,
                    ContractType = "Warranty",
                    ObligationType = "Commited",
                    UncommitedAmount = 0
                }
            }
        }
    }
};

contractService.Notify(contractMessage);
