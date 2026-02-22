using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.PaymentGateways.Stripe;

public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public string GatewayName => "Stripe";

    public IPaymentValidator CreateValidator()
    {
        return new StripeValidator();
    }

    public IPaymentProcessor CreateProcessor()
    {
        return new StripeProcessor();
    }

    public IPaymentLogger CreateLogger()
    {
        return new StripeLogger();
    }
}
