namespace POC_Observer.ReceivableUnit;

public class ReceivableUnitContract
{
    public string Document { get; set; }
    public string Debtor { get; set; }
    public string PaymentScheme { get; set; }
    public DateTime DueDate { get; set; }
    public DateTime ReferenceDate { get; set; }
    public long UncommitedAmount { get; set; }
    
}