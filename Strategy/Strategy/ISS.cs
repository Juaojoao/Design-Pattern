using Strategy.Contract;

namespace Strategy.Strategy;

public class ISS : ITaxStrategy
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.95m; // 5%
    }
}