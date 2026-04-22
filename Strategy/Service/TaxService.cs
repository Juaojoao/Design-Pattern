using Strategy.Contract;

namespace Strategy.Service;

public class TaxService
{
    private ITaxStrategy _taxStrategy;
    
    public decimal Calculate(decimal amount)
    {
        return _taxStrategy.Calculate(amount);
    }
    
    public void SetTaxStrategy(ITaxStrategy taxStrategy)
    {
        _taxStrategy = taxStrategy;
    }
    
    // Exemplo de implementação sem o padrão Strategy
    
    // public decimal Calculate(decimal amount, string taxType)
    // {
    //     if (taxType == "ICMS")
    //     {
    //         return amount * 0.80m; // 20%
    //     }
    //     
    //     if (taxType == "ISS")
    //     {
    //         return amount * 0.95m; // 5%
    //     }
    //
    //     if (taxType == "IPI")
    //     {
    //         return amount * 0.90m; // 10%
    //     }
    //
    //     return amount;
    // }
}