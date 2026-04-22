namespace Strategy.Contract;

public interface ITaxStrategy
{
    decimal Calculate(decimal amount);
}