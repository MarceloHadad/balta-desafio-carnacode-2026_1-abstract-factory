using DesignPatternChallenge.Interfaces;

namespace DesignPatternChallenge.PaymentGateways.PagSeguro;

public class PagSeguroGatewayFactory : IPaymentGatewayFactory
{
    public string GatewayName => "PagSeguro";

    public IPaymentValidator CreateValidator()
    {
        return new PagSeguroValidator();
    }

    public IPaymentProcessor CreateProcessor()
    {
        return new PagSeguroProcessor();
    }

    public IPaymentLogger CreateLogger()
    {
        return new PagSeguroLogger();
    }
}
