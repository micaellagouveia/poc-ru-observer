using POC_Observer.ReceivableUnit;

namespace POC_Observer.Contract;

public class ContractService: IContract
{
    private List<IObserver> _observers;

    public ContractService()
    {
        this._observers = new List<IObserver>();
    }
    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Notify(ContractMessage message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }
}