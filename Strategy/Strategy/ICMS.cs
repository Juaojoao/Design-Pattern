using Strategy.Contract;

namespace Strategy.Strategy;

public class ICMS : ITaxStrategy
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.80m; // 20%
    }
}