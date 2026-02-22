using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.PaymentGateways.Stripe;

public class StripeLogger : IPaymentLogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[Stripe Log] {DateTime.Now}: {message}");
    }
}
