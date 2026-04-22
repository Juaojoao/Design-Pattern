using Strategy.Contract;
using Strategy.Service;
using Strategy.Strategy;

namespace Strategy.Controller;

public class TaxController
{
    private readonly TaxService _taxService;
    
    public TaxController(TaxService taxService)
    {
        _taxService = taxService;
    }

    public decimal Calculate(string taxType, decimal amount)
    {
        ITaxStrategy strategy = taxType switch
        {
            "ICMS" => new ICMS(),
            "ISS" => new ISS(),
            "IPI" => new IPI(),
            _ => throw new ArgumentException("Invalid Tax Type")
        };

        _taxService.SetTaxStrategy(strategy);
        
        return _taxService.Calculate(amount);
    }
}