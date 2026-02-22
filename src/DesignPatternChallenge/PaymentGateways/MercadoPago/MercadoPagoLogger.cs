using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.PaymentGateways.MercadoPago;

public class MercadoPagoLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[MercadoPago Log] {DateTime.Now}: {message}");
    }
}
