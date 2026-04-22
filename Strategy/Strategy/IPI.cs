using Strategy.Contract;

namespace Strategy.Strategy;

public class IPI : ITaxStrategy
{
    public decimal Calculate(decimal amount)
    {
        return amount * 0.90m; // 10%
    }
}