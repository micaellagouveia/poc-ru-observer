using POC_Observer.ReceivableUnit;

namespace POC_Observer.Contract;

public interface IContract
{
    // função para que os observers possam se inscrever
    void Subscribe(IObserver observer);
    
    // função que notifica os observers com as mudanças nos contratos
    void Notify(ContractMessage message);
}
