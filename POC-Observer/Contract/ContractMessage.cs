namespace POC_Observer.Contract;

// mensagem que é enviada nas mensagens para os assinantes
public class ContractMessage
{
    public string Document { get; set; }
    public string Debtor { get; set; }
    public List<Receivable> Receivables { get; set; }
}

public class Receivable
{
    public string PaymentScheme { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReferenceDate { get; set; }
    public List<SettlementObligation> SettlementObligations { get; set; }
}

public class SettlementObligation
{
    public long UncommitedAmount { get; set; }
    public long CommitedAmount { get; set; }
    public string ContractType { get; set; }
    public string ObligationType { get; set; }
}
