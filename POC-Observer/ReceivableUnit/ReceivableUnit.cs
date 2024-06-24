using POC_Observer.Contract;

namespace POC_Observer.ReceivableUnit;

public class ReceivableUnit : IObserver
{
    public void Update(ContractMessage message)
    {
        Console.WriteLine($"Documento {message.Document} possui atualizações em seus contratos");
        var receivableUnitContracts = MapContractMessageToReceivableUnitContracts(message);

        Console.WriteLine("=============================");
        foreach (var ruContract in receivableUnitContracts)
        {
            Console.WriteLine($"Receivable Unit {ruContract.DueDate}-{ruContract.PaymentScheme}");
            Console.WriteLine($"  Valor registrado disponível para compensação: {ruContract.UncommitedAmount}");
            Console.WriteLine();
        }
    }

    private List<ReceivableUnitContract> MapContractMessageToReceivableUnitContracts(
        ContractMessage message
    )
    {
        var receivableUnitContractsByDocument = message
            .Receivables.Select(ru => new ReceivableUnitContract
            {
                DueDate = ru.DueDate,
                Debtor = message.Debtor,
                Document = message.Document,
                PaymentScheme = ru.PaymentScheme,
                ReferenceDate = ru.ReferenceDate,
                UncommitedAmount = ru.SettlementObligations.Sum(so => so.UncommitedAmount)
            })
            .Where(ru => ru.UncommitedAmount > 0);

        return receivableUnitContractsByDocument.ToList();
    }
}
