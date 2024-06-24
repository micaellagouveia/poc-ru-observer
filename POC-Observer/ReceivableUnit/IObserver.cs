using POC_Observer.Contract;

namespace POC_Observer.ReceivableUnit;

public interface IObserver
{
    // Função que atualiza a ru ao receber um evento de contrato
    void Update(ContractMessage message);
}