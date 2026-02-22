using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.PaymentGateways.PagSeguro;

public class PagSeguroLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}
